using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VGetNonSalesEmployeeInformation
{
    public int PersonId { get; set; }

    public string? PersonType { get; set; }

    public string PersonType2 { get; set; } = null!;

    public string? Title { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string? Suffix { get; set; }

    public string PersonName { get; set; } = null!;

    public string SocialSecurityNumber { get; set; } = null!;

    public string? LoginId { get; set; }

    public string? EmailAddress { get; set; }

    public string? PhoneNumber { get; set; }

    public string? PhoneNumberType { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? City { get; set; }

    public string? StateOrProvince { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? AddressTypeId { get; set; }

    public DateTime? BirthDate { get; set; }

    public string MaritalStatus { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public DateTime? HireDate { get; set; }

    public string? LengthOfService { get; set; }

    public string? JobGroup { get; set; }

    public string? JobDepartment { get; set; }

    public string? JobTitle { get; set; }

    public byte? ShiftId { get; set; }

    public string? ShiftNumber { get; set; }

    public string? ShiftName { get; set; }

    public decimal? HourlyPayRate { get; set; }

    public string PayFrequency { get; set; } = null!;

    public short? VacationHours { get; set; }

    public short? SickLeaveHours { get; set; }

    public string? SalesTerritory { get; set; }

    public string? Currency { get; set; }

    public string? CustomerAccountNumber { get; set; }

    public string? CreditCardType { get; set; }

    public string? CreditCardNumber { get; set; }

    public string? CreditCardExpiration { get; set; }

    public string? ShippingMethod { get; set; }

    public bool? SalariedFlag { get; set; }

    public bool? CurrentEmployee { get; set; }

    public DateTime? StartDate { get; set; }

    public long? RowNumber { get; set; }
}
