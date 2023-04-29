using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_recruitment_source")]
public partial class HrRecruitmentSource
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("source_id")]
    public Guid? SourceId { get; set; }

    [Column("job_id")]
    public Guid? JobId { get; set; }

    [Column("alias_id")]
    public Guid? AliasId { get; set; }

    [Column("medium_id")]
    public Guid? MediumId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("AliasId")]
    [InverseProperty("HrRecruitmentSources")]
    public virtual MailAlias? Alias { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrRecruitmentSourceCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("JobId")]
    [InverseProperty("HrRecruitmentSources")]
    public virtual HrJob? Job { get; set; }

    [ForeignKey("MediumId")]
    [InverseProperty("HrRecruitmentSources")]
    public virtual UtmMedium? Medium { get; set; }

    [ForeignKey("SourceId")]
    [InverseProperty("HrRecruitmentSources")]
    public virtual UtmSource? Source { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrRecruitmentSourceWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
