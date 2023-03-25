using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("hr_resume_line_type")]
public partial class HrResumeLineType
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("sequence")]
    public Guid? Sequence { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("HrResumeLineTypeCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("LineType")]
    public virtual ICollection<HrResumeLine> HrResumeLines { get; } = new List<HrResumeLine>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("HrResumeLineTypeWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
