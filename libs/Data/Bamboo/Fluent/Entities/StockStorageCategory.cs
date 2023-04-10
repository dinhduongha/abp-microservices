using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockStorageCategory
{
    public long Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? AllowNewProduct { get; set; }

    public decimal? MaxWeight { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<StockLocation> StockLocations { get; } = new List<StockLocation>();

    //public virtual ICollection<StockPutawayRule> StockPutawayRules { get; } = new List<StockPutawayRule>();

    //public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();

    //public virtual ICollection<StockStorageCategoryCapacity> StockStorageCategoryCapacities { get; } = new List<StockStorageCategoryCapacity>();

    public virtual ResUser? WriteU { get; set; }
}
