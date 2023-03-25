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
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("send_mail")]
    public bool? SendMail { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("ApplicantGetRefuseReasonCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("RefuseReasonId")]
    //[InverseProperty("ApplicantGetRefuseReasons")]
    public virtual HrApplicantRefuseReason? RefuseReason { get; set; }

    [ForeignKey("TemplateId")]
    //[InverseProperty("ApplicantGetRefuseReasons")]
    public virtual MailTemplate? Template { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("ApplicantGetRefuseReasonWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ApplicantGetRefuseReasonId")]
    [InverseProperty("ApplicantGetRefuseReasons")]
    [NotMapped]
    public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();
}
