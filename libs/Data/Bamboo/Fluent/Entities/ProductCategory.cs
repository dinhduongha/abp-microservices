using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProductCategory
{
    public long Id { get; set; }

    public long? ParentId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? CompleteName { get; set; }

    public string? ParentPath { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? RemovalStrategyId { get; set; }

    public string? PackagingReserveMethod { get; set; }

    //public virtual ICollection<AccountAnalyticApplicability> AccountAnalyticApplicabilities { get; } = new List<AccountAnalyticApplicability>();

    //public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModels { get; } = new List<AccountAnalyticDistributionModel>();

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<ProductCategory> InverseParent { get; } = new List<ProductCategory>();

    public virtual ProductCategory? Parent { get; set; }

    //public virtual ICollection<ProductPricelistItem> ProductPricelistItems { get; } = new List<ProductPricelistItem>();

    //public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();

    public virtual ProductRemoval? RemovalStrategy { get; set; }

    //public virtual ICollection<StockPutawayRule> StockPutawayRules { get; } = new List<StockPutawayRule>();

    //public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; } = new List<StockWarehouseOrderpoint>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<StockRoute> Routes { get; } = new List<StockRoute>();
}
