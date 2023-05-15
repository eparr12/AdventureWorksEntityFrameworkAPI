using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VGetVendorInformation
{
    public int BusinessEntityId { get; set; }

    public string AccountNumber { get; set; } = null!;

    public string Name { get; set; } = null!;

    public byte CreditRating { get; set; }

    public string? PreferredVendorStatus { get; set; }

    public string? Active { get; set; }

    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int AverageLeadTime { get; set; }

    public decimal StandardPrice { get; set; }

    public int MinOrderQty { get; set; }

    public int MaxOrderQty { get; set; }
}
