using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VGetWorkOrderInformation
{
    public int WorkOrderId { get; set; }

    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public short OperationSequence { get; set; }

    public short LocationId { get; set; }

    public string LocationName { get; set; } = null!;

    public int OrderQty { get; set; }

    public int StockedQty { get; set; }

    public short ScrappedQty { get; set; }

    public int DaysToManufacture { get; set; }

    public decimal? ActualResourceHrs { get; set; }

    public DateTime WorkOrderStartDate { get; set; }

    public DateTime? WorkOrderEndDate { get; set; }

    public DateTime WorkOrderDueDate { get; set; }

    public DateTime? OperationStartDate { get; set; }

    public DateTime? OperationEndDate { get; set; }
}
