using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VAddWorkOrder
{
    public int SalesOrderId { get; set; }

    public byte Status { get; set; }

    public int SalesOrderDetailId { get; set; }

    public int ProductId { get; set; }

    public short OrderQty { get; set; }
}
