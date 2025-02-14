using System;
using System.Collections.Generic;

namespace DBRepositories.Entities;

public partial class OperationDatum
{
    public int Id { get; set; }

    public byte NumOperator { get; set; }

    public string ModelCode { get; set; } = null!;

    public DateTime Date { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public virtual Model ModelCodeNavigation { get; set; } = null!;
}
