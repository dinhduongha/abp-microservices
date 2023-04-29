using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProductRemoval
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Method { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ProductCategory> ProductCategories { get; } = new List<ProductCategory>();

    public virtual ICollection<StockLocation> StockLocations { get; } = new List<StockLocation>();

    public virtual ResUser? WriteU { get; set; }
}
