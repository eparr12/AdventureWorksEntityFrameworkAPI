using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VEmployeeFullName
{
    public int BusinessEntityId { get; set; }

    public string Name { get; set; } = null!;

    public string PersonType { get; set; } = null!;
}
