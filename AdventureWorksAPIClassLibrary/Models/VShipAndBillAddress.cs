using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VShipAndBillAddress
{
    public int BusinessEntityId { get; set; }

    public int AddressId { get; set; }

    public long? RowNumber { get; set; }
}
