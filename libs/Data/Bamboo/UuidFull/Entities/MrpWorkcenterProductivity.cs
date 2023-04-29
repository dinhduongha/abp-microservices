using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mrp_workcenter_productivity")]
[Index("CompanyId", Name = "mrp_workcenter_productivity_company_id_index")]
[Index("WorkcenterId", Name = "mrp_workcenter_productivity_workcenter_id_index")]
[Index("WorkorderId", Name = "mrp_workcenter_productivity_workorder_id_index")]
public partial class MrpWorkcenterProductivity
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("workcenter_id")]
    public Guid? WorkcenterId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("workorder_id")]
    public Guid? WorkorderId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("loss_id")]
    public Guid? LossId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("loss_type")]
    public string? LossType { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("date_start", TypeName = "timestamp without time zone")]
    public DateTime? DateStart { get; set; }

    [Column("date_end", TypeName = "timestamp without time zone")]
    public DateTime? DateEnd { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("duration")]
    public double? Duration { get; set; }

    [Column("cost_already_recorded")]
    public bool? CostAlreadyRecorded { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("MrpWorkcenterProductivities")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MrpWorkcenterProductivityCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LossId")]
    [InverseProperty("MrpWorkcenterProductivities")]
    public virtual MrpWorkcenterProductivityLoss? Loss { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("MrpWorkcenterProductivityUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WorkcenterId")]
    [InverseProperty("MrpWorkcenterProductivities")]
    public virtual MrpWorkcenter? Workcenter { get; set; }

    [ForeignKey("WorkorderId")]
    [InverseProperty("MrpWorkcenterProductivities")]
    public virtual MrpWorkorder? Workorder { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MrpWorkcenterProductivityWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
