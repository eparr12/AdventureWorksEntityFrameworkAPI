using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VGetSalesOrderDetailInfo
{
    public int SalesOrderId { get; set; }

    public int SalesOrderDetailId { get; set; }

    public string? Status { get; set; }

    public string? CarrierTrackingNumber { get; set; }

    public short OrderQty { get; set; }

    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public decimal LineTotal { get; set; }
}
