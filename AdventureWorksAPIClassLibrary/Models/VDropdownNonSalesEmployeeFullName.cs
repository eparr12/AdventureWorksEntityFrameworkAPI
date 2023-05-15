using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VDropdownNonSalesEmployeeFullName
{
    public int BusinessEntityId { get; set; }

    public string FullName { get; set; } = null!;

    public string PersonType { get; set; } = null!;
}
