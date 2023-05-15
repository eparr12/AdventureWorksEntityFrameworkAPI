using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class VSalesStatus
{
    public int SalesOrderId { get; set; }

    public string? Status { get; set; }
}
