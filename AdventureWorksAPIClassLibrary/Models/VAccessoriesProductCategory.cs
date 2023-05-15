using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VAccessoriesProductCategory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string ProductNumber { get; set; } = null!;

    public string? Color { get; set; }

    public decimal? ListPrice { get; set; }

    public string? ProductLine { get; set; }

    public string? Class { get; set; }

    public string? Category { get; set; }

    public string? SubCategory { get; set; }

    public string? Model { get; set; }
}
