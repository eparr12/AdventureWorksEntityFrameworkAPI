using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VDeletePeopleStore
{
    public int BusinessEntityId { get; set; }

    public string? PersonType { get; set; }

    public string PersonName { get; set; } = null!;

    public int? AddressId { get; set; }

    public string? StoreName { get; set; }

    public int? CreditCardId { get; set; }

    public long? RowNumber { get; set; }
}
