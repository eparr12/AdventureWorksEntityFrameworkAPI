using System;
using System.Collections.Generic;

namespace AdventureWorksAPIClassLibrary.Models;

public partial class Password2
{
    public int BusinessEntityId { get; set; }

    public byte[] PasswordHash { get; set; } = null!;

    public Guid PasswordSalt { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }

    public string Role { get; set; } = null!;

    public virtual Person BusinessEntity { get; set; } = null!;
}
