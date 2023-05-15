using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VGetInventoryInformation
{
    public int? ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductNumber { get; set; }

    public int? SafetyStockLevel { get; set; }

    public int? ReorderPoint { get; set; }

    public int? OverallQty { get; set; }

    public int? BulkInventoryQty { get; set; }

    public string ProductionArea { get; set; } = null!;

    public short ProductionQty { get; set; }

    public string Shelf { get; set; } = null!;

    public byte Bin { get; set; }
}
