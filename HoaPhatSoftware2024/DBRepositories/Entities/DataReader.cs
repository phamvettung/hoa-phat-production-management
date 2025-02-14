using System;
using System.Collections.Generic;

namespace DBRepositories.Entities;

public partial class DataReader
{
    public int Id { get; set; }

    public string ModelCode { get; set; } = null!;

    public DateTime Date { get; set; }

    public string? Barcode { get; set; }

    public float GrossWeight { get; set; }

    public string? UserName { get; set; }

    public string? OperatorName { get; set; }

    public virtual Model ModelCodeNavigation { get; set; } = null!;
}
