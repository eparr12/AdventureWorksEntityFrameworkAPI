using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class BulkInventory
{
    public int? ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductNumber { get; set; }

    public int? Quantity { get; set; }

    public Guid? RowGuid { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Product? Product { get; set; }
}
