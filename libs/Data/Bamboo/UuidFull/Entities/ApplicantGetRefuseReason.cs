using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("applicant_get_refuse_reason")]
public partial class ApplicantGetRefuseReason
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("refuse_reason_id")]
    public Guid? RefuseReasonId { get; set; }

    [Column("template_id")]
    public Guid? TemplateId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("send_mail")]
    public bool? SendMail { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ApplicantGetRefuseReasonCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("RefuseReasonId")]
    [InverseProperty("ApplicantGetRefuseReasons")]
    public virtual HrApplicantRefuseReason? RefuseReason { get; set; }

    [ForeignKey("TemplateId")]
    [InverseProperty("ApplicantGetRefuseReasons")]
    public virtual MailTemplate? Template { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ApplicantGetRefuseReasonWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ApplicantGetRefuseReasonId")]
    [InverseProperty("ApplicantGetRefuseReasons")]
    public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();
}
