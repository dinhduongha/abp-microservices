using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockScrap
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? ProductUomId { get; set; }

    public Guid? LotId { get; set; }

    public Guid? PackageId { get; set; }

    public Guid? OwnerId { get; set; }

    public Guid? MoveId { get; set; }

    public Guid? PickingId { get; set; }

    public Guid? LocationId { get; set; }

    public Guid? ScrapLocationId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Origin { get; set; }

    public string? State { get; set; }

    public decimal? ScrapQty { get; set; }

    public DateTime? DateDone { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? ProductionId { get; set; }

    public Guid? WorkorderId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? Location { get; set; }

    public virtual StockLot? Lot { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual StockMove? Move { get; set; }

    public virtual ResPartner? Owner { get; set; }

    public virtual StockQuantPackage? Package { get; set; }

    public virtual StockPicking? Picking { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? ProductUom { get; set; }

    public virtual MrpProduction? Production { get; set; }

    public virtual StockLocation? ScrapLocation { get; set; }

    public virtual ICollection<StockWarnInsufficientQtyScrap> StockWarnInsufficientQtyScraps { get; } = new List<StockWarnInsufficientQtyScrap>();

    public virtual MrpWorkorder? Workorder { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
