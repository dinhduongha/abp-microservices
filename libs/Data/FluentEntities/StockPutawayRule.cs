using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockPutawayRule
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public long? CategoryId { get; set; }

    public Guid? LocationInId { get; set; }

    public Guid? LocationOutId { get; set; }

    public long Sequence { get; set; }

    public Guid? TenantId { get; set; }

    public long? StorageCategoryId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ProductCategory? Category { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? LocationIn { get; set; }

    public virtual StockLocation? LocationOut { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual StockStorageCategory? StorageCategory { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<StockPackageType> StockPackageTypes { get; } = new List<StockPackageType>();
}
