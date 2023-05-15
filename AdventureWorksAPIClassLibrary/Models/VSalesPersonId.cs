using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VSalesPersonId
{
    public int BusinessEntityId { get; set; }

    public string PersonName { get; set; } = null!;
}
