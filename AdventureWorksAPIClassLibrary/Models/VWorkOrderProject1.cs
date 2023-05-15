using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VWorkOrderProject1
{
    public int WorkOrderId { get; set; }

    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? OrderQty { get; set; }

    public string? StockedQty { get; set; }

    public string? ScrappedQty { get; set; }

    public string? ScrapReason { get; set; }

    public string? ScheduledStartDate { get; set; }

    public string? ActualStartDate { get; set; }

    public string? ScheduledEndDate { get; set; }

    public string? ActualEndDate { get; set; }

    public string? DueDate { get; set; }

    public short? OperationSequence { get; set; }

    public string? PlannedCost { get; set; }

    public string? ActualResourceHrs { get; set; }

    public string? ActualCost { get; set; }

    public string? ProductCategory { get; set; }

    public long? RowNumber { get; set; }
}
