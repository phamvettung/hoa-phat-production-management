using System;
using System.Collections.Generic;

namespace DBRepositories.Entities;

public partial class Account
{
    public string? AccountName { get; set; }

    public string UserName { get; set; } = null!;

    public string PassWord { get; set; } = null!;

    public byte Role { get; set; }
}
