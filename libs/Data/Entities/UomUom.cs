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

[Table("uom_uom")]
public partial class UomUom
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("category_id")]
    public long? CategoryId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("uom_type")]
    public string? UomType { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("factor")]
    public decimal? Factor { get; set; }

    [Column("rounding")]
    public decimal? Rounding { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [InverseProperty("ProductUom")]
    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    [InverseProperty("ProductUom")]
    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    [InverseProperty("AssociatedUom")]
    public virtual ICollection<BarcodeRule> BarcodeRules { get; } = new List<BarcodeRule>();

    [ForeignKey("CategoryId")]
    [InverseProperty("UomUoms")]
    public virtual UomCategory? Category { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("UomUomCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("ProductUom")]
    public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();

    [InverseProperty("ProductUom")]
    public virtual ICollection<MrpBomByproduct> MrpBomByproducts { get; } = new List<MrpBomByproduct>();

    [InverseProperty("ProductUom")]
    public virtual ICollection<MrpBomLine> MrpBomLines { get; } = new List<MrpBomLine>();

    [InverseProperty("ProductUom")]
    public virtual ICollection<MrpBom> MrpBoms { get; } = new List<MrpBom>();

    [InverseProperty("ProductUom")]
    public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();

    [InverseProperty("ProductUom")]
    public virtual ICollection<MrpUnbuild> MrpUnbuilds { get; } = new List<MrpUnbuild>();

    [InverseProperty("ProductUom")]
    public virtual ICollection<MrpWorkorder> MrpWorkorders { get; } = new List<MrpWorkorder>();

    [InverseProperty("ProductUom")]
    public virtual ICollection<ProductReplenish> ProductReplenishes { get; } = new List<ProductReplenish>();

    [InverseProperty("UomPo")]
    public virtual ICollection<ProductTemplate> ProductTemplateUomPos { get; } = new List<ProductTemplate>();

    [InverseProperty("Uom")]
    public virtual ICollection<ProductTemplate> ProductTemplateUoms { get; } = new List<ProductTemplate>();

    [InverseProperty("ProductUomNavigation")]
    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    [InverseProperty("ProductUomNavigation")]
    public virtual ICollection<RepairFee> RepairFees { get; } = new List<RepairFee>();

    [InverseProperty("ProductUomNavigation")]
    public virtual ICollection<RepairLine> RepairLines { get; } = new List<RepairLine>();

    [InverseProperty("ProductUomNavigation")]
    public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    [InverseProperty("ProductUomNavigation")]
    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();

    [InverseProperty("Uom")]
    public virtual ICollection<SaleOrderOption> SaleOrderOptions { get; } = new List<SaleOrderOption>();

    [InverseProperty("ProductUom")]
    public virtual ICollection<SaleOrderTemplateLine> SaleOrderTemplateLines { get; } = new List<SaleOrderTemplateLine>();

    [InverseProperty("Uom")]
    public virtual ICollection<SaleOrderTemplateOption> SaleOrderTemplateOptions { get; } = new List<SaleOrderTemplateOption>();

    [InverseProperty("ProductUom")]
    public virtual ICollection<StockLot> StockLots { get; } = new List<StockLot>();

    [InverseProperty("ProductUom")]
    public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();

    [InverseProperty("ProductUomNavigation")]
    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    [InverseProperty("ProductUom")]
    public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("UomUomWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
