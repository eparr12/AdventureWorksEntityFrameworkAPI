using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VGetPurchasingInformation
{
    public int PurchaseOrderId { get; set; }

    public int? PurchaseOrderDetailId { get; set; }

    public string? Status { get; set; }

    public string? OrderDate { get; set; }

    public string? ShipDate { get; set; }

    public string? SubTotal { get; set; }

    public string? TaxAmt { get; set; }

    public string? FreightCost { get; set; }

    public string? TotalDue { get; set; }

    public string? DueDate { get; set; }

    public string? OrderQty { get; set; }

    public string? ProductName { get; set; }

    public int? ProductId { get; set; }

    public string? UnitPrice { get; set; }

    public string? LineTotal { get; set; }

    public string? ReceivedQty { get; set; }

    public string? RejectedQty { get; set; }

    public string? StockedQty { get; set; }

    public string? ShipMethod { get; set; }

    public string? AccountNumber { get; set; }

    public string EmployeeName { get; set; } = null!;

    public int? EmployeeId { get; set; }

    public string? AverageLeadTime { get; set; }

    public string? StandardPrice { get; set; }

    public string? ProductCategory { get; set; }

    public long? RowNumber { get; set; }
}
