using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("product_pricelist")]
public partial class ProductPricelist
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("discount_policy")]
    public string? DiscountPolicy { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("website_id")]
    public Guid? WebsiteId { get; set; }

    [Column("code")]
    public string? Code { get; set; }

    [Column("selectable")]
    public bool? Selectable { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("ProductPricelists")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProductPricelistCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Pricelist")]
    public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();

    [InverseProperty("Pricelist")]
    public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    [InverseProperty("BasePricelist")]
    public virtual ICollection<ProductPricelistItem> ProductPricelistItemBasePricelists { get; } = new List<ProductPricelistItem>();

    [InverseProperty("Pricelist")]
    public virtual ICollection<ProductPricelistItem> ProductPricelistItemPricelists { get; } = new List<ProductPricelistItem>();

    [InverseProperty("Pricelist")]
    public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    [InverseProperty("PosPricelist")]
    public virtual ICollection<ResConfigSetting> ResConfigSettingsNavigation { get; } = new List<ResConfigSetting>();

    [InverseProperty("Pricelist")]
    public virtual ICollection<ResCountryGroupPricelistRel> ResCountryGroupPricelistRels { get; } = new List<ResCountryGroupPricelistRel>();

    [InverseProperty("Pricelist")]
    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    [ForeignKey("WebsiteId")]
    [InverseProperty("ProductPricelists")]
    public virtual Website? Website { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ProductPricelistWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ProductPricelistId")]
    [InverseProperty("ProductPricelists")]
    public virtual ICollection<PosConfig> PosConfigsNavigation { get; } = new List<PosConfig>();

    [ForeignKey("ProductPricelistId")]
    [InverseProperty("ProductPricelists")]
    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; } = new List<ResConfigSetting>();
}
