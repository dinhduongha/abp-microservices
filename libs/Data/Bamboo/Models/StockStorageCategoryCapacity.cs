using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockStorageCategoryCapacity
{
    public Guid Id { get; set; }

    public long? StorageCategoryId { get; set; }

    public Guid? ProductId { get; set; }

    public long? PackageTypeId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? Quantity { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockPackageType? PackageType { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual StockStorageCategory? StorageCategory { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
