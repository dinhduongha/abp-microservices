using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockPackageType
{
    public long Id { get; set; }

    public long Sequence { get; set; }

    public long? Height { get; set; }

    public long? Width { get; set; }

    public long? PackagingLength { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Barcode { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? BaseWeight { get; set; }

    public double? MaxWeight { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<ProductPackaging> ProductPackagings { get; } = new List<ProductPackaging>();

    //public virtual ICollection<StockQuantPackage> StockQuantPackages { get; } = new List<StockQuantPackage>();

    //public virtual ICollection<StockStorageCategoryCapacity> StockStorageCategoryCapacities { get; } = new List<StockStorageCategoryCapacity>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<StockPutawayRule> StockPutawayRules { get; } = new List<StockPutawayRule>();
}
