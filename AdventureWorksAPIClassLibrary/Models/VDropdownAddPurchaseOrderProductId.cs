using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VDropdownAddPurchaseOrderProductId
{
    public string VendorName { get; set; } = null!;

    public int BusinessEntityId { get; set; }

    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
