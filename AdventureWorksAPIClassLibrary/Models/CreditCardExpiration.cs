using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class CreditCardExpiration
{
    public byte? ExpMonth { get; set; }

    public short? ExpYear { get; set; }
}
