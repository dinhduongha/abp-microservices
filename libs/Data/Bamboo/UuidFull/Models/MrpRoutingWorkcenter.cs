using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MrpRoutingWorkcenter
{
    public Guid Id { get; set; }

    public Guid? WorkcenterId { get; set; }

    public long Sequence { get; set; }

    public Guid? BomId { get; set; }

    public long? TimeModeBatch { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? WorksheetType { get; set; }

    public string? WorksheetGoogleSlide { get; set; }

    public string? TimeMode { get; set; }

    public string? Note { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? TimeCycleManual { get; set; }

    public virtual MrpBom? Bom { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MrpBomByproduct> MrpBomByproducts { get; } = new List<MrpBomByproduct>();

    public virtual ICollection<MrpBomLine> MrpBomLines { get; } = new List<MrpBomLine>();

    public virtual ICollection<MrpWorkorder> MrpWorkorders { get; } = new List<MrpWorkorder>();

    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    public virtual MrpWorkcenter? Workcenter { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<MrpRoutingWorkcenter> BlockedBies { get; } = new List<MrpRoutingWorkcenter>();

    public virtual ICollection<MrpRoutingWorkcenter> Operations { get; } = new List<MrpRoutingWorkcenter>();

    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; } = new List<ProductTemplateAttributeValue>();
}
