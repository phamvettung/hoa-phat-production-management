using System;
using System.Collections.Generic;

namespace DBRepositories.Entities;

public partial class Model
{
    public string ModelCode { get; set; } = null!;

    public string? ModelName { get; set; }

    public float GrossWeight { get; set; }

    public int ToLerance { get; set; }

    public virtual ICollection<DataReader> DataReaders { get; set; } = new List<DataReader>();

    public virtual ICollection<ModelDatum> ModelData { get; set; } = new List<ModelDatum>();

    public virtual ICollection<OperationDatum> OperationData { get; set; } = new List<OperationDatum>();

    public virtual ICollection<ProductionOrder> ProductionOrders { get; set; } = new List<ProductionOrder>();
}
