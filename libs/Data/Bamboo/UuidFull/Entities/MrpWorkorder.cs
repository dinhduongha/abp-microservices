﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mrp_workorder")]
public partial class MrpWorkorder
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("workcenter_id")]
    public Guid? WorkcenterId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("product_uom_id")]
    public Guid? ProductUomId { get; set; }

    [Column("production_id")]
    public Guid? ProductionId { get; set; }

    [Column("leave_id")]
    public Guid? LeaveId { get; set; }

    [Column("duration_percent")]
    public long? DurationPercent { get; set; }

    [Column("operation_id")]
    public Guid? OperationId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("production_availability")]
    public string? ProductionAvailability { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("qty_produced")]
    public decimal? QtyProduced { get; set; }

    [Column("duration_expected")]
    public decimal? DurationExpected { get; set; }

    [Column("qty_reported_from_previous_wo")]
    public decimal? QtyReportedFromPreviousWo { get; set; }

    [Column("date_planned_start", TypeName = "timestamp without time zone")]
    public DateTime? DatePlannedStart { get; set; }

    [Column("date_planned_finished", TypeName = "timestamp without time zone")]
    public DateTime? DatePlannedFinished { get; set; }

    [Column("date_start", TypeName = "timestamp without time zone")]
    public DateTime? DateStart { get; set; }

    [Column("date_finished", TypeName = "timestamp without time zone")]
    public DateTime? DateFinished { get; set; }

    [Column("production_date", TypeName = "timestamp without time zone")]
    public DateTime? ProductionDate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("duration")]
    public double? Duration { get; set; }

    [Column("duration_unit")]
    public double? DurationUnit { get; set; }

    [Column("costs_hour")]
    public double? CostsHour { get; set; }

    [Column("mo_analytic_account_line_id")]
    public Guid? MoAnalyticAccountLineId { get; set; }

    [Column("wc_analytic_account_line_id")]
    public Guid? WcAnalyticAccountLineId { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MrpWorkorderCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LeaveId")]
    [InverseProperty("MrpWorkorders")]
    public virtual ResourceCalendarLeaf? Leave { get; set; }

    [ForeignKey("MoAnalyticAccountLineId")]
    [InverseProperty("MrpWorkorderMoAnalyticAccountLines")]
    public virtual AccountAnalyticLine? MoAnalyticAccountLine { get; set; }

    [InverseProperty("Workorder")]
    public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivities { get; } = new List<MrpWorkcenterProductivity>();

    [ForeignKey("OperationId")]
    [InverseProperty("MrpWorkorders")]
    public virtual MrpRoutingWorkcenter? Operation { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("MrpWorkorders")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("ProductUomId")]
    [InverseProperty("MrpWorkorders")]
    public virtual UomUom? ProductUom { get; set; }

    [ForeignKey("ProductionId")]
    [InverseProperty("MrpWorkorders")]
    public virtual MrpProduction? Production { get; set; }

    [InverseProperty("Workorder")]
    public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();

    [InverseProperty("Workorder")]
    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    [InverseProperty("Workorder")]
    public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    [ForeignKey("WcAnalyticAccountLineId")]
    [InverseProperty("MrpWorkorderWcAnalyticAccountLines")]
    public virtual AccountAnalyticLine? WcAnalyticAccountLine { get; set; }

    [ForeignKey("WorkcenterId")]
    [InverseProperty("MrpWorkorders")]
    public virtual MrpWorkcenter? Workcenter { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MrpWorkorderWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("WorkorderId")]
    [InverseProperty("Workorders")]
    public virtual ICollection<MrpWorkorder> BlockedBies { get; } = new List<MrpWorkorder>();

    [ForeignKey("BlockedById")]
    [InverseProperty("BlockedBies")]
    public virtual ICollection<MrpWorkorder> Workorders { get; } = new List<MrpWorkorder>();
}
