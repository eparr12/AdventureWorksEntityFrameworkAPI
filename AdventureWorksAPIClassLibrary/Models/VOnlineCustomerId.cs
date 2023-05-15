using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VOnlineCustomerId
{
    public int CustomerId { get; set; }

    public int? PersonId { get; set; }

    public string PersonName { get; set; } = null!;

    public string? PersonType { get; set; }

    public int? StoreId { get; set; }

    public string? Name { get; set; }

    public string AccountNumber { get; set; } = null!;
}
