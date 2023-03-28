using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProductRemoval
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Method { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<ProductCategory> ProductCategories { get; } = new List<ProductCategory>();

    //public virtual ICollection<StockLocation> StockLocations { get; } = new List<StockLocation>();

    public virtual ResUser? WriteU { get; set; }
}
