using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VSalesOrderUnitPrice
{
    public int ProductId { get; set; }

    public decimal? ActualCost { get; set; }

    public decimal? StandardPrice { get; set; }

    public long? RowNumberStandardPrice { get; set; }

    public long? RowNumberActual { get; set; }

    public long? RowNumber { get; set; }
}
