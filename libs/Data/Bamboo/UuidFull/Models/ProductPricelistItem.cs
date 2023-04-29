using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProductPricelistItem
{
    public Guid Id { get; set; }

    public Guid? PricelistId { get; set; }

    public Guid? CompanyId { get; set; }

    public long? CurrencyId { get; set; }

    public long? CategId { get; set; }

    public Guid? ProductTmplId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? BasePricelistId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? AppliedOn { get; set; }

    public string? Base { get; set; }

    public string? ComputePrice { get; set; }

    public decimal? MinQuantity { get; set; }

    public decimal? FixedPrice { get; set; }

    public decimal? PriceDiscount { get; set; }

    public decimal? PriceRound { get; set; }

    public decimal? PriceSurcharge { get; set; }

    public decimal? PriceMinMargin { get; set; }

    public decimal? PriceMaxMargin { get; set; }

    public bool? Active { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? PercentPrice { get; set; }

    public virtual ProductPricelist? BasePricelist { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductPricelist? Pricelist { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ProductTemplate? ProductTmpl { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
