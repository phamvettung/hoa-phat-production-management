using System;
using System.Collections.Generic;

namespace DBRepositories.Entities;

public partial class ProductionOrder
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public string ModelCode { get; set; } = null!;

    public short ExpectedOutput { get; set; }

    public short ActualOutput { get; set; }

    public string Status { get; set; } = null!;

    public virtual Model ModelCodeNavigation { get; set; } = null!;
}
