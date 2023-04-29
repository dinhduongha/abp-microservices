using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mrp_routing_workcenter")]
[Index("BomId", Name = "mrp_routing_workcenter_bom_id_index")]
public partial class MrpRoutingWorkcenter
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("workcenter_id")]
    public Guid? WorkcenterId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("bom_id")]
    public Guid? BomId { get; set; }

    [Column("time_mode_batch")]
    public long? TimeModeBatch { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("worksheet_type")]
    public string? WorksheetType { get; set; }

    [Column("worksheet_google_slide")]
    public string? WorksheetGoogleSlide { get; set; }

    [Column("time_mode")]
    public string? TimeMode { get; set; }

    [Column("note")]
    public string? Note { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("time_cycle_manual")]
    public double? TimeCycleManual { get; set; }

    [ForeignKey("BomId")]
    [InverseProperty("MrpRoutingWorkcenters")]
    public virtual MrpBom? Bom { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MrpRoutingWorkcenterCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Operation")]
    public virtual ICollection<MrpBomByproduct> MrpBomByproducts { get; } = new List<MrpBomByproduct>();

    [InverseProperty("Operation")]
    public virtual ICollection<MrpBomLine> MrpBomLines { get; } = new List<MrpBomLine>();

    [InverseProperty("Operation")]
    public virtual ICollection<MrpWorkorder> MrpWorkorders { get; } = new List<MrpWorkorder>();

    [InverseProperty("Operation")]
    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    [ForeignKey("WorkcenterId")]
    [InverseProperty("MrpRoutingWorkcenters")]
    public virtual MrpWorkcenter? Workcenter { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MrpRoutingWorkcenterWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("OperationId")]
    [InverseProperty("Operations")]
    public virtual ICollection<MrpRoutingWorkcenter> BlockedBies { get; } = new List<MrpRoutingWorkcenter>();

    [ForeignKey("BlockedById")]
    [InverseProperty("BlockedBies")]
    public virtual ICollection<MrpRoutingWorkcenter> Operations { get; } = new List<MrpRoutingWorkcenter>();

    [ForeignKey("MrpRoutingWorkcenterId")]
    [InverseProperty("MrpRoutingWorkcenters")]
    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; } = new List<ProductTemplateAttributeValue>();
}
