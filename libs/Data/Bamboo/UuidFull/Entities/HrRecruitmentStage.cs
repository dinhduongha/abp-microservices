using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_recruitment_stage")]
public partial class HrRecruitmentStage
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("template_id")]
    public Guid? TemplateId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("legend_blocked", TypeName = "jsonb")]
    public string? LegendBlocked { get; set; }

    [Column("legend_done", TypeName = "jsonb")]
    public string? LegendDone { get; set; }

    [Column("legend_normal", TypeName = "jsonb")]
    public string? LegendNormal { get; set; }

    [Column("requirements")]
    public string? Requirements { get; set; }

    [Column("fold")]
    public bool? Fold { get; set; }

    [Column("hired_stage")]
    public bool? HiredStage { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrRecruitmentStageCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("TemplateId")]
    [InverseProperty("HrRecruitmentStages")]
    public virtual MailTemplate? Template { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrRecruitmentStageWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
