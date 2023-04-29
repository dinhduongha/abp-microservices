using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MrpWorkorder
{
    public Guid Id { get; set; }

    public Guid? WorkcenterId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? ProductUomId { get; set; }

    public Guid? ProductionId { get; set; }

    public Guid? LeaveId { get; set; }

    public long? DurationPercent { get; set; }

    public Guid? OperationId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? ProductionAvailability { get; set; }

    public string? State { get; set; }

    public decimal? QtyProduced { get; set; }

    public decimal? DurationExpected { get; set; }

    public decimal? QtyReportedFromPreviousWo { get; set; }

    public DateTime? DatePlannedStart { get; set; }

    public DateTime? DatePlannedFinished { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateFinished { get; set; }

    public DateTime? ProductionDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? Duration { get; set; }

    public double? DurationUnit { get; set; }

    public double? CostsHour { get; set; }

    public Guid? MoAnalyticAccountLineId { get; set; }

    public Guid? WcAnalyticAccountLineId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResourceCalendarLeaf? Leave { get; set; }

    public virtual AccountAnalyticLine? MoAnalyticAccountLine { get; set; }

    public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivities { get; } = new List<MrpWorkcenterProductivity>();

    public virtual MrpRoutingWorkcenter? Operation { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? ProductUom { get; set; }

    public virtual MrpProduction? Production { get; set; }

    public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();

    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    public virtual AccountAnalyticLine? WcAnalyticAccountLine { get; set; }

    public virtual MrpWorkcenter? Workcenter { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<MrpWorkorder> BlockedBies { get; } = new List<MrpWorkorder>();

    public virtual ICollection<MrpWorkorder> Workorders { get; } = new List<MrpWorkorder>();
}
