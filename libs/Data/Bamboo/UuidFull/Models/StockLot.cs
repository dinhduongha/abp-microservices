using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockLot
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? ProductUomId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Ref { get; set; }

    public string? Note { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();

    public virtual ICollection<MrpUnbuild> MrpUnbuilds { get; } = new List<MrpUnbuild>();

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? ProductUom { get; set; }

    public virtual ICollection<RepairLine> RepairLines { get; } = new List<RepairLine>();

    public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();

    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();

    public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    public virtual ResUser? WriteU { get; set; }
}
