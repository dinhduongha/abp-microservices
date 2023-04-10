using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProductProduct
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? ProductTmplId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? DefaultCode { get; set; }

    public string? Barcode { get; set; }

    public string? CombinationIndices { get; set; }

    public decimal? Volume { get; set; }

    public decimal? Weight { get; set; }

    public bool? Active { get; set; }

    public bool? CanImageVariant1024BeZoomed { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? BaseUnitId { get; set; }

    public double? BaseUnitCount { get; set; }

    //public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModels { get; } = new List<AccountAnalyticDistributionModel>();

    //public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    //public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    public virtual WebsiteBaseUnit? BaseUnit { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; } = new List<HrExpenseSplit>();

    //public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    //public virtual ICollection<MrpBomByproduct> MrpBomByproducts { get; } = new List<MrpBomByproduct>();

    //public virtual ICollection<MrpBomLine> MrpBomLines { get; } = new List<MrpBomLine>();

    //public virtual ICollection<MrpBom> MrpBoms { get; } = new List<MrpBom>();

    //public virtual ICollection<MrpConsumptionWarningLine> MrpConsumptionWarningLines { get; } = new List<MrpConsumptionWarningLine>();

    //public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();

    //public virtual ICollection<MrpUnbuild> MrpUnbuilds { get; } = new List<MrpUnbuild>();

    //public virtual ICollection<MrpWorkcenterCapacity> MrpWorkcenterCapacities { get; } = new List<MrpWorkcenterCapacity>();

    //public virtual ICollection<MrpWorkorder> MrpWorkorders { get; } = new List<MrpWorkorder>();

    //public virtual ICollection<PosConfig> PosConfigDownPaymentProducts { get; } = new List<PosConfig>();

    //public virtual ICollection<PosConfig> PosConfigTipProducts { get; } = new List<PosConfig>();

    //public virtual ICollection<PosOrderLine> PosOrderLines { get; } = new List<PosOrderLine>();

    //public virtual ICollection<ProductImage> ProductImages { get; } = new List<ProductImage>();

    //public virtual ICollection<ProductPackaging> ProductPackagings { get; } = new List<ProductPackaging>();

    //public virtual ICollection<ProductPricelistItem> ProductPricelistItems { get; } = new List<ProductPricelistItem>();

    //public virtual ICollection<ProductReplenish> ProductReplenishes { get; } = new List<ProductReplenish>();

    //public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; } = new List<ProductSupplierinfo>();

    public virtual ProductTemplate? ProductTmpl { get; set; }

    //public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    //public virtual ICollection<RepairFee> RepairFees { get; } = new List<RepairFee>();

    //public virtual ICollection<RepairLine> RepairLines { get; } = new List<RepairLine>();

    //public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    //public virtual ICollection<ResConfigSetting> ResConfigSettingDepositDefaultProducts { get; } = new List<ResConfigSetting>();

    //public virtual ICollection<ResConfigSetting> ResConfigSettingPosTipProducts { get; } = new List<ResConfigSetting>();

    //public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvs { get; } = new List<SaleAdvancePaymentInv>();

    //public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();

    //public virtual ICollection<SaleOrderOption> SaleOrderOptions { get; } = new List<SaleOrderOption>();

    //public virtual ICollection<SaleOrderTemplateLine> SaleOrderTemplateLines { get; } = new List<SaleOrderTemplateLine>();

    //public virtual ICollection<SaleOrderTemplateOption> SaleOrderTemplateOptions { get; } = new List<SaleOrderTemplateOption>();

    //public virtual ICollection<StockChangeProductQty> StockChangeProductQties { get; } = new List<StockChangeProductQty>();

    //public virtual ICollection<StockLot> StockLots { get; } = new List<StockLot>();

    //public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();

    //public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    //public virtual ICollection<StockPutawayRule> StockPutawayRules { get; } = new List<StockPutawayRule>();

    //public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();

    //public virtual ICollection<StockReplenishmentOption> StockReplenishmentOptions { get; } = new List<StockReplenishmentOption>();

    //public virtual ICollection<StockReturnPickingLine> StockReturnPickingLines { get; } = new List<StockReturnPickingLine>();

    //public virtual ICollection<StockRulesReport> StockRulesReports { get; } = new List<StockRulesReport>();

    //public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    //public virtual ICollection<StockStorageCategoryCapacity> StockStorageCategoryCapacities { get; } = new List<StockStorageCategoryCapacity>();

    //public virtual ICollection<StockTrackLine> StockTrackLines { get; } = new List<StockTrackLine>();

    //public virtual ICollection<StockValuationLayerRevaluation> StockValuationLayerRevaluations { get; } = new List<StockValuationLayerRevaluation>();

    //public virtual ICollection<StockValuationLayer> StockValuationLayers { get; } = new List<StockValuationLayer>();

    //public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; } = new List<StockWarehouseOrderpoint>();

    //public virtual ICollection<StockWarnInsufficientQtyRepair> StockWarnInsufficientQtyRepairs { get; } = new List<StockWarnInsufficientQtyRepair>();

    //public virtual ICollection<StockWarnInsufficientQtyScrap> StockWarnInsufficientQtyScraps { get; } = new List<StockWarnInsufficientQtyScrap>();

    //public virtual ICollection<StockWarnInsufficientQtyUnbuild> StockWarnInsufficientQtyUnbuilds { get; } = new List<StockWarnInsufficientQtyUnbuild>();

    //public virtual ICollection<WebsiteTrack> WebsiteTracks { get; } = new List<WebsiteTrack>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ProductLabelLayout> ProductLabelLayouts { get; } = new List<ProductLabelLayout>();

    //public virtual ICollection<ProductTag> ProductTags { get; } = new List<ProductTag>();

    //public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; } = new List<ProductTemplateAttributeValue>();

    //public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();

    //public virtual ICollection<ProductTemplate> Srcs { get; } = new List<ProductTemplate>();

    //public virtual ICollection<StockTrackConfirmation> StockTrackConfirmations { get; } = new List<StockTrackConfirmation>();
}
