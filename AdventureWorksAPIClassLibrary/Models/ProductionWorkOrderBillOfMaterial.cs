using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class ProductionWorkOrderBillOfMaterial
{
    public int WorkOrderId { get; set; }

    public int? ProductAssemblyId { get; set; }

    public int? ComponentId { get; set; }

    public string? ComponentDesc { get; set; }

    public int? TotalQuantity { get; set; }

    public decimal? StandardCost { get; set; }

    public decimal? ListPrice { get; set; }

    public int? Bomlevel { get; set; }

    public int? RecursionLevel { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual WorkOrder WorkOrder { get; set; } = null!;
}
