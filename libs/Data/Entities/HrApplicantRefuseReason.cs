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

[Table("hr_applicant_refuse_reason")]
public partial class HrApplicantRefuseReason
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("template_id")]
    public Guid? TemplateId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [InverseProperty("RefuseReason")]
    public virtual ICollection<ApplicantGetRefuseReason> ApplicantGetRefuseReasons { get; } = new List<ApplicantGetRefuseReason>();

    [ForeignKey("CreatorId")]
    [InverseProperty("HrApplicantRefuseReasonCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("RefuseReason")]
    public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    [ForeignKey("TemplateId")]
    [InverseProperty("HrApplicantRefuseReasons")]
    public virtual MailTemplate? Template { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("HrApplicantRefuseReasonWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
