using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProductPricelist
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? DiscountPolicy { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? WebsiteId { get; set; }

    public string? Code { get; set; }

    public bool? Selectable { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();

    public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    public virtual ICollection<ProductPricelistItem> ProductPricelistItemBasePricelists { get; } = new List<ProductPricelistItem>();

    public virtual ICollection<ProductPricelistItem> ProductPricelistItemPricelists { get; } = new List<ProductPricelistItem>();

    public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    public virtual ICollection<ResConfigSetting> ResConfigSettingsNavigation { get; } = new List<ResConfigSetting>();

    public virtual ICollection<ResCountryGroupPricelistRel> ResCountryGroupPricelistRels { get; } = new List<ResCountryGroupPricelistRel>();

    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<PosConfig> PosConfigsNavigation { get; } = new List<PosConfig>();

    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; } = new List<ResConfigSetting>();
}
