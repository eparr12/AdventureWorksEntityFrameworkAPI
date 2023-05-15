using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VDeleteVender
{
    public string Name { get; set; } = null!;

    public int BusinessEntityId { get; set; }

    public int AddressId { get; set; }

    public int? ProductId { get; set; }

    public long? RowNumber { get; set; }
}
