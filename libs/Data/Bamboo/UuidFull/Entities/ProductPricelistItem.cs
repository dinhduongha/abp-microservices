using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("product_pricelist_item")]
[Index("ComputePrice", Name = "product_pricelist_item_compute_price_index")]
[Index("PricelistId", Name = "product_pricelist_item_pricelist_id_index")]
public partial class ProductPricelistItem
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("pricelist_id")]
    public Guid? PricelistId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("categ_id")]
    public long? CategId { get; set; }

    [Column("product_tmpl_id")]
    public Guid? ProductTmplId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("base_pricelist_id")]
    public Guid? BasePricelistId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("applied_on")]
    public string? AppliedOn { get; set; }

    [Column("base")]
    public string? Base { get; set; }

    [Column("compute_price")]
    public string? ComputePrice { get; set; }

    [Column("min_quantity")]
    public decimal? MinQuantity { get; set; }

    [Column("fixed_price")]
    public decimal? FixedPrice { get; set; }

    [Column("price_discount")]
    public decimal? PriceDiscount { get; set; }

    [Column("price_round")]
    public decimal? PriceRound { get; set; }

    [Column("price_surcharge")]
    public decimal? PriceSurcharge { get; set; }

    [Column("price_min_margin")]
    public decimal? PriceMinMargin { get; set; }

    [Column("price_max_margin")]
    public decimal? PriceMaxMargin { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("date_start", TypeName = "timestamp without time zone")]
    public DateTime? DateStart { get; set; }

    [Column("date_end", TypeName = "timestamp without time zone")]
    public DateTime? DateEnd { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("percent_price")]
    public double? PercentPrice { get; set; }

    [ForeignKey("BasePricelistId")]
    [InverseProperty("ProductPricelistItemBasePricelists")]
    public virtual ProductPricelist? BasePricelist { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("ProductPricelistItems")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProductPricelistItemCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PricelistId")]
    [InverseProperty("ProductPricelistItemPricelists")]
    public virtual ProductPricelist? Pricelist { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("ProductPricelistItems")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("ProductTmplId")]
    [InverseProperty("ProductPricelistItems")]
    public virtual ProductTemplate? ProductTmpl { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ProductPricelistItemWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
