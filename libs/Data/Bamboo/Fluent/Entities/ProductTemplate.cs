using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProductTemplate
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public long Sequence { get; set; }

    public long? CategId { get; set; }

    public Guid? UomId { get; set; }

    public Guid? UomPoId { get; set; }

    public Guid? TenantId { get; set; }

    public long? Color { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? DetailedType { get; set; }

    public string? Type { get; set; }

    public string? DefaultCode { get; set; }

    public string? Priority { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? DescriptionPurchase { get; set; }

    public string? DescriptionSale { get; set; }

    public decimal? ListPrice { get; set; }

    public decimal? Volume { get; set; }

    public decimal? Weight { get; set; }

    public bool? SaleOk { get; set; }

    public bool? PurchaseOk { get; set; }

    public bool? Active { get; set; }

    public bool? CanImage1024BeZoomed { get; set; }

    public bool? HasConfigurableAttributes { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? ServiceType { get; set; }

    public string? SaleLineWarn { get; set; }

    public string? ExpensePolicy { get; set; }

    public string? InvoicePolicy { get; set; }

    public string? SaleLineWarnMsg { get; set; }

    public string? Tracking { get; set; }

    public string? DescriptionPicking { get; set; }

    public string? DescriptionPickingout { get; set; }

    public string? DescriptionPickingin { get; set; }

    public double? SaleDelay { get; set; }

    public long? PosCategId { get; set; }

    public bool? AvailableInPos { get; set; }

    public bool? ToWeight { get; set; }

    public string? PurchaseMethod { get; set; }

    public string? PurchaseLineWarn { get; set; }

    public string? PurchaseLineWarnMsg { get; set; }

    public double? ProduceDelay { get; set; }

    public double? DaysToPrepareMo { get; set; }

    public string? ServiceTracking { get; set; }

    public bool? CanBeExpensed { get; set; }

    public Guid? WebsiteId { get; set; }

    public long? WebsiteSizeX { get; set; }

    public long? WebsiteSizeY { get; set; }

    public Guid? WebsiteRibbonId { get; set; }

    public long? WebsiteSequence { get; set; }

    public Guid? BaseUnitId { get; set; }

    public string? WebsiteMetaOgImg { get; set; }

    public string? WebsiteMetaTitle { get; set; }

    public string? WebsiteMetaDescription { get; set; }

    public string? WebsiteMetaKeywords { get; set; }

    public string? SeoName { get; set; }

    public string? WebsiteDescription { get; set; }

    public decimal? CompareListPrice { get; set; }

    public bool? IsPublished { get; set; }

    public double? RatingLastValue { get; set; }

    public double? BaseUnitCount { get; set; }

    public string? OutOfStockMessage { get; set; }

    public bool? AllowOutOfStockOrder { get; set; }

    public bool? ShowAvailability { get; set; }

    public double? AvailableThreshold { get; set; }

    public virtual WebsiteBaseUnit? BaseUnit { get; set; }

    public virtual ProductCategory? Categ { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    //public virtual ICollection<MrpBomLine> MrpBomLines { get; } = new List<MrpBomLine>();

    //public virtual ICollection<MrpBom> MrpBoms { get; } = new List<MrpBom>();

    public virtual PosCategory? PosCateg { get; set; }

    //public virtual ICollection<ProductImage> ProductImages { get; } = new List<ProductImage>();

    //public virtual ICollection<ProductPricelistItem> ProductPricelistItems { get; } = new List<ProductPricelistItem>();

    //public virtual ICollection<ProductProduct> ProductProducts { get; } = new List<ProductProduct>();

    //public virtual ICollection<ProductReplenish> ProductReplenishes { get; } = new List<ProductReplenish>();

    //public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; } = new List<ProductSupplierinfo>();

    //public virtual ICollection<ProductTemplateAttributeExclusion> ProductTemplateAttributeExclusions { get; } = new List<ProductTemplateAttributeExclusion>();

    //public virtual ICollection<ProductTemplateAttributeLine> ProductTemplateAttributeLines { get; } = new List<ProductTemplateAttributeLine>();

    //public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; } = new List<ProductTemplateAttributeValue>();

    //public virtual ICollection<StockChangeProductQty> StockChangeProductQties { get; } = new List<StockChangeProductQty>();

    //public virtual ICollection<StockRulesReport> StockRulesReports { get; } = new List<StockRulesReport>();

    public virtual UomUom? Uom { get; set; }

    public virtual UomUom? UomPo { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ProductRibbon? WebsiteRibbon { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountAccountTag> AccountAccountTags { get; } = new List<AccountAccountTag>();

    //public virtual ICollection<ProductProduct> Dests { get; } = new List<ProductProduct>();

    //public virtual ICollection<ProductTemplate> Dests1 { get; } = new List<ProductTemplate>();

    //public virtual ICollection<ProductTemplate> DestsNavigation { get; } = new List<ProductTemplate>();

    //public virtual ICollection<ProductAttribute> ProductAttributes { get; } = new List<ProductAttribute>();

    //public virtual ICollection<ProductLabelLayout> ProductLabelLayouts { get; } = new List<ProductLabelLayout>();

    //public virtual ICollection<ProductPublicCategory> ProductPublicCategories { get; } = new List<ProductPublicCategory>();

    //public virtual ICollection<ProductTag> ProductTags { get; } = new List<ProductTag>();

    //public virtual ICollection<StockRoute> Routes { get; } = new List<StockRoute>();

    //public virtual ICollection<ProductTemplate> Srcs { get; } = new List<ProductTemplate>();

    //public virtual ICollection<ProductTemplate> SrcsNavigation { get; } = new List<ProductTemplate>();

    //public virtual ICollection<AccountTax> Taxes { get; } = new List<AccountTax>();

    //public virtual ICollection<AccountTax> TaxesNavigation { get; } = new List<AccountTax>();
}
