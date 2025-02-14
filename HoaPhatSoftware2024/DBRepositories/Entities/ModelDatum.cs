using System;
using System.Collections.Generic;

namespace DBRepositories.Entities;

public partial class ModelDatum
{
    public int Id { get; set; }

    public string ModelCode { get; set; } = null!;

    public DateTime Date { get; set; }

    public short ExpectedOutput { get; set; }

    public short ActualOutput { get; set; }

    public virtual Model ModelCodeNavigation { get; set; } = null!;
}
