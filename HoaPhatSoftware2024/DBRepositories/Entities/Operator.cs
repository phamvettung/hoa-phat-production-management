using System;
using System.Collections.Generic;

namespace DBRepositories.Entities;

public partial class Operator
{
    public string ModelCode { get; set; } = null!;

    public byte NumOperator { get; set; }

    public string? OperatorName { get; set; }

    public TimeSpan ExcutionTime { get; set; }

    public bool IsIgnore { get; set; }

    public virtual Model ModelCodeNavigation { get; set; } = null!;
}
