using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VGetCustomerStoreInformation
{
    public int BusinessEntityId { get; set; }

    public string Name { get; set; } = null!;

    public int CustomerId { get; set; }

    public string AccountNumber { get; set; } = null!;

    public int? SalesPersonId { get; set; }

    public string SalesPerson { get; set; } = null!;

    public int? ContactId { get; set; }

    public string? ContactName { get; set; }

    public string AddressType { get; set; } = null!;

    public string AddressLine1 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string Territory { get; set; } = null!;
}
