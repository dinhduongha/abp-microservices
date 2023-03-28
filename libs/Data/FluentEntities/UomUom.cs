using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class UomUom
{
    public Guid Id { get; set; }

    public long? CategoryId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? UomType { get; set; }

    public string? Name { get; set; }

    public decimal? Factor { get; set; }

    public decimal? Rounding { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    //public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    //public virtual ICollection<BarcodeRule> BarcodeRules { get; } = new List<BarcodeRule>();

    public virtual UomCategory? Category { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();

    //public virtual ICollection<MrpBomByproduct> MrpBomByproducts { get; } = new List<MrpBomByproduct>();

    //public virtual ICollection<MrpBomLine> MrpBomLines { get; } = new List<MrpBomLine>();

    //public virtual ICollection<MrpBom> MrpBoms { get; } = new List<MrpBom>();

    //public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();

    //public virtual ICollection<MrpUnbuild> MrpUnbuilds { get; } = new List<MrpUnbuild>();

    //public virtual ICollection<MrpWorkorder> MrpWorkorders { get; } = new List<MrpWorkorder>();

    //public virtual ICollection<ProductReplenish> ProductReplenishes { get; } = new List<ProductReplenish>();

    //public virtual ICollection<ProductTemplate> ProductTemplateUomPos { get; } = new List<ProductTemplate>();

    //public virtual ICollection<ProductTemplate> ProductTemplateUoms { get; } = new List<ProductTemplate>();

    //public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    //public virtual ICollection<RepairFee> RepairFees { get; } = new List<RepairFee>();

    //public virtual ICollection<RepairLine> RepairLines { get; } = new List<RepairLine>();

    //public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    //public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();

    //public virtual ICollection<SaleOrderOption> SaleOrderOptions { get; } = new List<SaleOrderOption>();

    //public virtual ICollection<SaleOrderTemplateLine> SaleOrderTemplateLines { get; } = new List<SaleOrderTemplateLine>();

    //public virtual ICollection<SaleOrderTemplateOption> SaleOrderTemplateOptions { get; } = new List<SaleOrderTemplateOption>();

    //public virtual ICollection<StockLot> StockLots { get; } = new List<StockLot>();

    //public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();

    //public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    //public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    public virtual ResUser? WriteU { get; set; }
}
