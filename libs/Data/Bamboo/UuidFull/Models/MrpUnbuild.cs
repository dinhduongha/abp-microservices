using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MrpUnbuild
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? ProductUomId { get; set; }

    public Guid? BomId { get; set; }

    public Guid? MoId { get; set; }

    public Guid? LotId { get; set; }

    public Guid? LocationId { get; set; }

    public Guid? LocationDestId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? State { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? ProductQty { get; set; }

    public virtual MrpBom? Bom { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? Location { get; set; }

    public virtual StockLocation? LocationDest { get; set; }

    public virtual StockLot? Lot { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual MrpProduction? Mo { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? ProductUom { get; set; }

    public virtual ICollection<StockMove> StockMoveConsumeUnbuilds { get; } = new List<StockMove>();

    public virtual ICollection<StockMove> StockMoveUnbuilds { get; } = new List<StockMove>();

    public virtual ICollection<StockWarnInsufficientQtyUnbuild> StockWarnInsufficientQtyUnbuilds { get; } = new List<StockWarnInsufficientQtyUnbuild>();

    public virtual ResUser? WriteU { get; set; }
}
