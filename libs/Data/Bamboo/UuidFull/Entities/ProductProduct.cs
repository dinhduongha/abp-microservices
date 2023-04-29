﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("product_product")]
[Index("CombinationIndices", Name = "product_product_combination_indices_index")]
[Index("DefaultCode", Name = "product_product_default_code_index")]
[Index("ProductTmplId", Name = "product_product_product_tmpl_id_index")]
public partial class ProductProduct
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("product_tmpl_id")]
    public Guid? ProductTmplId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("default_code")]
    public string? DefaultCode { get; set; }

    [Column("barcode")]
    public string? Barcode { get; set; }

    [Column("combination_indices")]
    public string? CombinationIndices { get; set; }

    [Column("volume")]
    public decimal? Volume { get; set; }

    [Column("weight")]
    public decimal? Weight { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("can_image_variant_1024_be_zoomed")]
    public bool? CanImageVariant1024BeZoomed { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("base_unit_id")]
    public Guid? BaseUnitId { get; set; }

    [Column("base_unit_count")]
    public double? BaseUnitCount { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModels { get; } = new List<AccountAnalyticDistributionModel>();

    [InverseProperty("Product")]
    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    [InverseProperty("Product")]
    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    [ForeignKey("BaseUnitId")]
    [InverseProperty("ProductProducts")]
    public virtual WebsiteBaseUnit? BaseUnit { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProductProductCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; } = new List<HrExpenseSplit>();

    [InverseProperty("Product")]
    public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("ProductProducts")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<MrpBomByproduct> MrpBomByproducts { get; } = new List<MrpBomByproduct>();

    [InverseProperty("Product")]
    public virtual ICollection<MrpBomLine> MrpBomLines { get; } = new List<MrpBomLine>();

    [InverseProperty("Product")]
    public virtual ICollection<MrpBom> MrpBoms { get; } = new List<MrpBom>();

    [InverseProperty("Product")]
    public virtual ICollection<MrpConsumptionWarningLine> MrpConsumptionWarningLines { get; } = new List<MrpConsumptionWarningLine>();

    [InverseProperty("Product")]
    public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();

    [InverseProperty("Product")]
    public virtual ICollection<MrpUnbuild> MrpUnbuilds { get; } = new List<MrpUnbuild>();

    [InverseProperty("Product")]
    public virtual ICollection<MrpWorkcenterCapacity> MrpWorkcenterCapacities { get; } = new List<MrpWorkcenterCapacity>();

    [InverseProperty("Product")]
    public virtual ICollection<MrpWorkorder> MrpWorkorders { get; } = new List<MrpWorkorder>();

    [InverseProperty("DownPaymentProduct")]
    public virtual ICollection<PosConfig> PosConfigDownPaymentProducts { get; } = new List<PosConfig>();

    [InverseProperty("TipProduct")]
    public virtual ICollection<PosConfig> PosConfigTipProducts { get; } = new List<PosConfig>();

    [InverseProperty("Product")]
    public virtual ICollection<PosOrderLine> PosOrderLines { get; } = new List<PosOrderLine>();

    [InverseProperty("ProductVariant")]
    public virtual ICollection<ProductImage> ProductImages { get; } = new List<ProductImage>();

    [InverseProperty("Product")]
    public virtual ICollection<ProductPackaging> ProductPackagings { get; } = new List<ProductPackaging>();

    [InverseProperty("Product")]
    public virtual ICollection<ProductPricelistItem> ProductPricelistItems { get; } = new List<ProductPricelistItem>();

    [InverseProperty("Product")]
    public virtual ICollection<ProductReplenish> ProductReplenishes { get; } = new List<ProductReplenish>();

    [InverseProperty("Product")]
    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; } = new List<ProductSupplierinfo>();

    [InverseProperty("ProductProduct")]
    public virtual ICollection<ProductTagProductProductRel> ProductTagProductProductRels { get; } = new List<ProductTagProductProductRel>();

    [ForeignKey("ProductTmplId")]
    [InverseProperty("ProductProducts")]
    public virtual ProductTemplate? ProductTmpl { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    [InverseProperty("Product")]
    public virtual ICollection<RepairFee> RepairFees { get; } = new List<RepairFee>();

    [InverseProperty("Product")]
    public virtual ICollection<RepairLine> RepairLines { get; } = new List<RepairLine>();

    [InverseProperty("Product")]
    public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    [InverseProperty("DepositDefaultProduct")]
    public virtual ICollection<ResConfigSetting> ResConfigSettingDepositDefaultProducts { get; } = new List<ResConfigSetting>();

    [InverseProperty("PosTipProduct")]
    public virtual ICollection<ResConfigSetting> ResConfigSettingPosTipProducts { get; } = new List<ResConfigSetting>();

    [InverseProperty("Product")]
    public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvs { get; } = new List<SaleAdvancePaymentInv>();

    [InverseProperty("Product")]
    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();

    [InverseProperty("Product")]
    public virtual ICollection<SaleOrderOption> SaleOrderOptions { get; } = new List<SaleOrderOption>();

    [InverseProperty("Product")]
    public virtual ICollection<SaleOrderTemplateLine> SaleOrderTemplateLines { get; } = new List<SaleOrderTemplateLine>();

    [InverseProperty("Product")]
    public virtual ICollection<SaleOrderTemplateOption> SaleOrderTemplateOptions { get; } = new List<SaleOrderTemplateOption>();

    [InverseProperty("Product")]
    public virtual ICollection<StockChangeProductQty> StockChangeProductQties { get; } = new List<StockChangeProductQty>();

    [InverseProperty("Product")]
    public virtual ICollection<StockLot> StockLots { get; } = new List<StockLot>();

    [InverseProperty("Product")]
    public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();

    [InverseProperty("Product")]
    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    [InverseProperty("Product")]
    public virtual ICollection<StockPutawayRule> StockPutawayRules { get; } = new List<StockPutawayRule>();

    [InverseProperty("Product")]
    public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();

    [InverseProperty("Product")]
    public virtual ICollection<StockReplenishmentOption> StockReplenishmentOptions { get; } = new List<StockReplenishmentOption>();

    [InverseProperty("Product")]
    public virtual ICollection<StockReturnPickingLine> StockReturnPickingLines { get; } = new List<StockReturnPickingLine>();

    [InverseProperty("Product")]
    public virtual ICollection<StockRulesReport> StockRulesReports { get; } = new List<StockRulesReport>();

    [InverseProperty("Product")]
    public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    [InverseProperty("Product")]
    public virtual ICollection<StockStorageCategoryCapacity> StockStorageCategoryCapacities { get; } = new List<StockStorageCategoryCapacity>();

    [InverseProperty("Product")]
    public virtual ICollection<StockTrackLine> StockTrackLines { get; } = new List<StockTrackLine>();

    [InverseProperty("Product")]
    public virtual ICollection<StockValuationLayerRevaluation> StockValuationLayerRevaluations { get; } = new List<StockValuationLayerRevaluation>();

    [InverseProperty("Product")]
    public virtual ICollection<StockValuationLayer> StockValuationLayers { get; } = new List<StockValuationLayer>();

    [InverseProperty("Product")]
    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; } = new List<StockWarehouseOrderpoint>();

    [InverseProperty("Product")]
    public virtual ICollection<StockWarnInsufficientQtyRepair> StockWarnInsufficientQtyRepairs { get; } = new List<StockWarnInsufficientQtyRepair>();

    [InverseProperty("Product")]
    public virtual ICollection<StockWarnInsufficientQtyScrap> StockWarnInsufficientQtyScraps { get; } = new List<StockWarnInsufficientQtyScrap>();

    [InverseProperty("Product")]
    public virtual ICollection<StockWarnInsufficientQtyUnbuild> StockWarnInsufficientQtyUnbuilds { get; } = new List<StockWarnInsufficientQtyUnbuild>();

    [InverseProperty("Product")]
    public virtual ICollection<WebsiteTrack> WebsiteTracks { get; } = new List<WebsiteTrack>();

    [ForeignKey("WriteUid")]
    [InverseProperty("ProductProductWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ProductProductId")]
    [InverseProperty("ProductProducts")]
    public virtual ICollection<ProductLabelLayout> ProductLabelLayouts { get; } = new List<ProductLabelLayout>();

    [ForeignKey("ProductProductId")]
    [InverseProperty("ProductProducts")]
    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; } = new List<ProductTemplateAttributeValue>();

    [ForeignKey("ProductProductId")]
    [InverseProperty("ProductProducts")]
    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();

    [ForeignKey("DestId")]
    [InverseProperty("Dests")]
    public virtual ICollection<ProductTemplate> Srcs { get; } = new List<ProductTemplate>();

    [ForeignKey("ProductProductId")]
    [InverseProperty("ProductProducts")]
    public virtual ICollection<StockTrackConfirmation> StockTrackConfirmations { get; } = new List<StockTrackConfirmation>();
}
