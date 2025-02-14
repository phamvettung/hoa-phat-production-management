using System;
using System.Collections.Generic;

namespace DBRepositories.Entities;

public partial class ErrorDatum
{
    public int Id { get; set; }

    public DateTime Ngay { get; set; }

    public string BitError { get; set; } = null!;

    public virtual Error BitErrorNavigation { get; set; } = null!;
}
