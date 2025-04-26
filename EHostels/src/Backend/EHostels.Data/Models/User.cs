using System;
using System.Collections.Generic;

namespace EHostels.Api;

public partial class User
{
    public long EntityId { get; set; }

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Password { get; set; }

    public bool? IsActive { get; set; }

    public long? RoleId { get; set; }
}
