using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VGetSalesOrderHeaderInfo
{
    public int SalesOrderId { get; set; }

    public byte RevisionNumber { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime DueDate { get; set; }

    public DateTime? ShipDate { get; set; }

    public int? NumberDaysLate { get; set; }

    public string? Status { get; set; }

    public string? OnlineOrder { get; set; }

    public string SalesOrderNumber { get; set; } = null!;

    public string? PurchaseOrderNumber { get; set; }

    public string? AccountNumber { get; set; }

    public string CustomerContact { get; set; } = null!;

    public string? SalesPerson { get; set; }

    public string SalesTerritory { get; set; } = null!;

    public string? ShipToAddress { get; set; }

    public string? ShipToCity { get; set; }

    public string? ShipToStateOrProvince { get; set; }

    public string? ShipToPostalCode { get; set; }

    public string? ShipToCountry { get; set; }

    public string? BillToAddress { get; set; }

    public string? BillToCity { get; set; }

    public string? BillToStateOrProvince { get; set; }

    public string? BillToPostalCode { get; set; }

    public string? BillToCountry { get; set; }

    public string ShipMethod { get; set; } = null!;

    public string? CreditCardType { get; set; }

    public string? CreditCardNumber { get; set; }

    public string? CreditCardExpiration { get; set; }

    public string? CreditCardApprovalCode { get; set; }

    public string? CurrencyCode { get; set; }

    public string? CurrencyName { get; set; }

    public decimal? CurrencyRate { get; set; }

    public decimal SubTotal { get; set; }

    public decimal TaxAmt { get; set; }

    public decimal Freight { get; set; }

    public decimal TotalDue { get; set; }

    public string? Comment { get; set; }
}
