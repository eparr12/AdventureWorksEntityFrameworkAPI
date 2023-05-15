using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VProductionInformationProject1
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string VendorPartNumber { get; set; } = null!;

    public string? Color { get; set; }

    public string? Size { get; set; }

    public string? SizeUnits { get; set; }

    public decimal? Weight { get; set; }

    public string? WeightUnits { get; set; }

    public string? ProductLine { get; set; }

    public string? Class { get; set; }

    public string? Style { get; set; }

    public string? ProductCategory { get; set; }

    public string? ProductSubcategory { get; set; }

    public string? ProductModel { get; set; }

    public string? ProductDescription { get; set; }

    public string? ProductCulture { get; set; }

    public string? ProductLocation { get; set; }

    public string? Shelf { get; set; }

    public byte? Bin { get; set; }

    public string? Quantity { get; set; }

    public int? WorkOrderId { get; set; }

    public long? RowNumber { get; set; }
}
