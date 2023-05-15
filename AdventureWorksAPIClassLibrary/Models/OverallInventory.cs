using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class OverallInventory
{
    public int? ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductNumber { get; set; }

    public int? SafetyStockLevel { get; set; }

    public int? ReorderPoint { get; set; }

    public int? RowNumber { get; set; }

    public Guid? RowGuid { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? Quantity { get; set; }

    public virtual Product? Product { get; set; }
}
