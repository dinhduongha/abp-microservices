using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("product_pricelist")]
public partial class ProductPricelist: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("discount_policy")]
    public string? DiscountPolicy { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("website_id")]
    public Guid? WebsiteId { get; set; }

    [Column("code")]
    public string? Code { get; set; }

    [Column("selectable")]
    public bool? Selectable { get; set; }

    [ForeignKey("TenantId")]
    [InverseProperty("ProductPricelists")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("ProductPricelistCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CurrencyId")]
    [InverseProperty("ProductPricelists")]
    public virtual ResCurrency? Currency { get; set; }

    [InverseProperty("Pricelist")]
    [NotMapped]
    public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();

    [InverseProperty("Pricelist")]
    [NotMapped]
    public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    [InverseProperty("BasePricelist")]
    [NotMapped]
    public virtual ICollection<ProductPricelistItem> ProductPricelistItemBasePricelists { get; } = new List<ProductPricelistItem>();

    [InverseProperty("Pricelist")]
    [NotMapped]
    public virtual ICollection<ProductPricelistItem> ProductPricelistItemPricelists { get; } = new List<ProductPricelistItem>();

    [InverseProperty("Pricelist")]
    [NotMapped]
    public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    [InverseProperty("PosPricelist")]
    [NotMapped]
    public virtual ICollection<ResConfigSetting> ResConfigSettingsNavigation { get; } = new List<ResConfigSetting>();

    [InverseProperty("Pricelist")]
    [NotMapped]
    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    [ForeignKey("WebsiteId")]
    [InverseProperty("ProductPricelists")]
    public virtual Website? Website { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("ProductPricelistWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ProductPricelistId")]
    [InverseProperty("ProductPricelists")]
    [NotMapped]
    public virtual ICollection<PosConfig> PosConfigsNavigation { get; } = new List<PosConfig>();

    [ForeignKey("ProductPricelistId")]
    [InverseProperty("ProductPricelists")]
    [NotMapped]
    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; } = new List<ResConfigSetting>();

    [ForeignKey("PricelistId")]
    [InverseProperty("Pricelists")]
    [NotMapped]
    public virtual ICollection<ResCountryGroup> ResCountryGroups { get; } = new List<ResCountryGroup>();
}
