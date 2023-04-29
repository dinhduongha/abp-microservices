using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("project_task_type")]
[Index("UserId", Name = "project_task_type_user_id_index")]
public partial class ProjectTaskType
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("mail_template_id")]
    public Guid? MailTemplateId { get; set; }

    [Column("rating_template_id")]
    public Guid? RatingTemplateId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("description", TypeName = "jsonb")]
    public string? Description { get; set; }

    [Column("legend_blocked", TypeName = "jsonb")]
    public string? LegendBlocked { get; set; }

    [Column("legend_done", TypeName = "jsonb")]
    public string? LegendDone { get; set; }

    [Column("legend_normal", TypeName = "jsonb")]
    public string? LegendNormal { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("fold")]
    public bool? Fold { get; set; }

    [Column("auto_validation_kanban_state")]
    public bool? AutoValidationKanbanState { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("sms_template_id")]
    public Guid? SmsTemplateId { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProjectTaskTypeCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MailTemplateId")]
    [InverseProperty("ProjectTaskTypeMailTemplates")]
    public virtual MailTemplate? MailTemplate { get; set; }

    [ForeignKey("RatingTemplateId")]
    [InverseProperty("ProjectTaskTypeRatingTemplates")]
    public virtual MailTemplate? RatingTemplate { get; set; }

    [ForeignKey("SmsTemplateId")]
    [InverseProperty("ProjectTaskTypes")]
    public virtual SmsTemplate? SmsTemplate { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("ProjectTaskTypeUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ProjectTaskTypeWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
