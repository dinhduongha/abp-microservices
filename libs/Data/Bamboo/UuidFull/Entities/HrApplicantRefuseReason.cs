using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_applicant_refuse_reason")]
public partial class HrApplicantRefuseReason
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("template_id")]
    public Guid? TemplateId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [InverseProperty("RefuseReason")]
    public virtual ICollection<ApplicantGetRefuseReason> ApplicantGetRefuseReasons { get; } = new List<ApplicantGetRefuseReason>();

    [ForeignKey("CreateUid")]
    [InverseProperty("HrApplicantRefuseReasonCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("RefuseReason")]
    public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    [ForeignKey("TemplateId")]
    [InverseProperty("HrApplicantRefuseReasons")]
    public virtual MailTemplate? Template { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrApplicantRefuseReasonWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
