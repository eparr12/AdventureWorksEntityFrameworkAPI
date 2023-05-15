using AdventureWorksAPIClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

namespace AdventureWorksAPI
{
    public static class Api
    {
        private static AdventureWorks2014Context _context = new AdventureWorks2014Context();

        public static async void ConfigureApi(this WebApplication app)
        {
            //NonSalesEmployees Endpoint Mappings
            app.MapGet("/NonSalesEmployees/", async Task<IResult> () =>
            {
                try
                {
                    return Results.Ok(await _context.People.Where(p => p.PersonType == "EM")
                                         .Include(p => p.Employee)
                                         .Include(p => p.Password2)
                                         .Include(p => p.PersonPhones)
                                         .Include(p => p.EmailAddresses)
                                         .Include(p => p.BusinessEntity.BusinessEntityAddresses)
                                         .Select(p => new
                                         {
                                             p,
                                             p.PersonPhones,
                                             p.PersonPhones.FirstOrDefault().PhoneNumberType,
                                             p.EmailAddresses,
                                             p.BusinessEntity.BusinessEntityAddresses.FirstOrDefault().Address,
                                             p.BusinessEntity.BusinessEntityAddresses.FirstOrDefault().Address.StateProvince,
                                             p.BusinessEntity.BusinessEntityAddresses.FirstOrDefault().Address.StateProvince.CountryRegionCodeNavigation
                                         })
                                         .ToListAsync());
                }
                catch (Exception ex)
                {
                    return Results.Problem(ex.Message);
                }
            });

            app.MapGet("/NonSalesEmployees/{employeeFullName}", async Task<IResult> (string fullName) =>
            {
                try
                {
                    return Results.Ok(await _context.People.Where(p => p.FirstName + " " + p.MiddleName + " " + p.LastName == fullName)
                                         .Include(p => p.Employee)
                                         .Include(p => p.Password2)
                                         .Include(p => p.PersonPhones)
                                         .Include(p => p.EmailAddresses)
                                         .Include(p => p.BusinessEntity.BusinessEntityAddresses)
                                         .Select(p => new
                                         {
                                             p,
                                             p.PersonPhones,
                                             p.PersonPhones.FirstOrDefault().PhoneNumberType,
                                             p.EmailAddresses,
                                             p.BusinessEntity.BusinessEntityAddresses.FirstOrDefault().Address,
                                             p.BusinessEntity.BusinessEntityAddresses.FirstOrDefault().Address.StateProvince,
                                             p.BusinessEntity.BusinessEntityAddresses.FirstOrDefault().Address.StateProvince.CountryRegionCodeNavigation
                                         })
                                         .ToListAsync());
                }
                catch (Exception ex)
                {
                    return Results.Problem(ex.Message);
                }
            });

            app.MapPost("/NonSalesEmployees", async Task<IResult> (Person person) =>
            {
                try
                {
                    _context.People.Add(person);
                    return Results.Ok(await _context.SaveChangesAsync());
                }
                catch (Exception ex)
                {
                    return Results.Problem(ex.Message);
                }
            });

            app.MapPut("/NonSalesEmployees", async Task<IResult> (Person person, string fullName) =>
            {
                try
                {
                    if (person != null && fullName != null)
                    {
                        if (_context.People.Any(p => p.FirstName + " " + p.MiddleName + " " + p.LastName == fullName))
                        {
                            var _person = _context.People.Where(p => p.FirstName + " " + p.MiddleName + " " + p.LastName
                                                           == fullName).FirstOrDefault();
                            {
                                if (_person == person)
                                {
                                    return Results.Text("No information was changed!");
                                }
                                else
                                {
                                    var updatePerson = _context.People.Find(_person.BusinessEntityId);
                                    updatePerson = _person;
                                    return Results.Ok(await _context.SaveChangesAsync());
                                }
                            }
                        }
                        else
                        {
                            return Results.Text($"Could not find {fullName}. Please try again!");
                        }
                    }
                    else
                    {
                        return Results.Text("All values must be submitted!");
                    }
                }
                catch (Exception ex)
                {
                    return Results.Problem(ex.Message);
                }
            });

            app.MapDelete("/NonSalesEmployees/{fullName}", async Task<IResult> (string fullName) =>
            {
                try
                {
                    var id = _context.People.Where(p => p.FirstName + " " + p.MiddleName + " " + p.LastName
                                                   == fullName)
                                            .Select(p => p.BusinessEntityId).SingleOrDefault();

                    var addressId = _context.BusinessEntityAddresses.Where(b => b.BusinessEntityId == id)
                                        .Select(p => p.AddressId).SingleOrDefault();

                    if (id != null)
                    {
                        var rmvEmployee = _context.BusinessEntities.Find(id);
                        var rmvAddress = _context.Addresses.Find(addressId);
                        if (rmvEmployee != null)
                        {
                            _context.BusinessEntities.Remove(rmvEmployee);
                            _context.Addresses.Remove(rmvAddress);
                            return Results.Ok(await _context.SaveChangesAsync());
                        }
                        return Results.Ok();
                    }
                    else
                    {
                        return Results.Ok();
                    }
                }
                catch (Exception ex)
                {
                    return Results.Problem(ex.Message);
                }
            });
        }
    }
}
