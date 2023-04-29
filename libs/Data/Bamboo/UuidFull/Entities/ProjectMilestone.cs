using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("project_milestone")]
public partial class ProjectMilestone
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("project_id")]
    public Guid? ProjectId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("deadline")]
    public DateOnly? Deadline { get; set; }

    [Column("reached_date")]
    public DateOnly? ReachedDate { get; set; }

    [Column("is_reached")]
    public bool? IsReached { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("sale_line_id")]
    public Guid? SaleLineId { get; set; }

    [Column("quantity_percentage")]
    public double? QuantityPercentage { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProjectMilestoneCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("ProjectMilestones")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("ProjectId")]
    [InverseProperty("ProjectMilestones")]
    public virtual ProjectProject? Project { get; set; }

    [InverseProperty("Milestone")]
    public virtual ICollection<ProjectTask> ProjectTasks { get; } = new List<ProjectTask>();

    [ForeignKey("SaleLineId")]
    [InverseProperty("ProjectMilestones")]
    public virtual SaleOrderLine? SaleLine { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ProjectMilestoneWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
