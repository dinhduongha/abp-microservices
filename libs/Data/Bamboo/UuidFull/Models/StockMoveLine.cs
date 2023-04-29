using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockMoveLine
{
    public Guid Id { get; set; }

    public Guid? PickingId { get; set; }

    public Guid? MoveId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? ProductUomId { get; set; }

    public Guid? PackageId { get; set; }

    public Guid? PackageLevelId { get; set; }

    public Guid? LotId { get; set; }

    public Guid? ResultPackageId { get; set; }

    public Guid? OwnerId { get; set; }

    public Guid? LocationId { get; set; }

    public Guid? LocationDestId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? ProductCategoryName { get; set; }

    public string? LotName { get; set; }

    public string? State { get; set; }

    public string? Reference { get; set; }

    public string? DescriptionPicking { get; set; }

    public decimal? ReservedQty { get; set; }

    public decimal? ReservedUomQty { get; set; }

    public decimal? QtyDone { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? WorkorderId { get; set; }

    public Guid? ProductionId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? Location { get; set; }

    public virtual StockLocation? LocationDest { get; set; }

    public virtual StockLot? Lot { get; set; }

    public virtual StockMove? Move { get; set; }

    public virtual ResPartner? Owner { get; set; }

    public virtual StockQuantPackage? Package { get; set; }

    public virtual StockPackageLevel? PackageLevel { get; set; }

    public virtual StockPicking? Picking { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? ProductUom { get; set; }

    public virtual MrpProduction? Production { get; set; }

    public virtual StockQuantPackage? ResultPackage { get; set; }

    public virtual MrpWorkorder? Workorder { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockMoveLine> ConsumeLines { get; } = new List<StockMoveLine>();

    public virtual ICollection<StockMoveLine> ProduceLines { get; } = new List<StockMoveLine>();

    public virtual ICollection<ProductLabelLayout> ProductLabelLayouts { get; } = new List<ProductLabelLayout>();
}
