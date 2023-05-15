using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VSalesCommissionsProject1
{
    public int SalesOrderId { get; set; }

    public string Customer { get; set; } = null!;

    public string CustomerContact { get; set; } = null!;

    public string CreditCardType { get; set; } = null!;

    public string CreditCardNumber { get; set; } = null!;

    public string? CreditCardExpiration { get; set; }

    public string Address { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string City { get; set; } = null!;

    public string StateOrProvince { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Territory { get; set; } = null!;

    public string? SalesPerson { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime DueDate { get; set; }

    public DateTime? ShipDate { get; set; }

    public int? NumberDaysLate { get; set; }

    public string? Status { get; set; }

    public string? CommissionPercentage { get; set; }

    public decimal FreightCost { get; set; }

    public decimal TotalDue { get; set; }

    public decimal? TotalSales { get; set; }

    public decimal? SalesCommission { get; set; }

    public decimal Bonus { get; set; }

    public decimal? TotalRevenue { get; set; }

    public int? SalesPersonId { get; set; }
}
