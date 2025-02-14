using System;
using System.Collections.Generic;

namespace DBRepositories.Entities;

public partial class Error
{
    public string BitError { get; set; } = null!;

    public string? ErrorName { get; set; }

    public string? Solution { get; set; }

    public virtual ICollection<ErrorDatum> ErrorData { get; set; } = new List<ErrorDatum>();
}
