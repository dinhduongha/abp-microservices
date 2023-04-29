using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("project_project_stage")]
public partial class ProjectProjectStage
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("mail_template_id")]
    public Guid? MailTemplateId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("fold")]
    public bool? Fold { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("sms_template_id")]
    public Guid? SmsTemplateId { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProjectProjectStageCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MailTemplateId")]
    [InverseProperty("ProjectProjectStages")]
    public virtual MailTemplate? MailTemplate { get; set; }

    [ForeignKey("SmsTemplateId")]
    [InverseProperty("ProjectProjectStages")]
    public virtual SmsTemplate? SmsTemplate { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ProjectProjectStageWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
