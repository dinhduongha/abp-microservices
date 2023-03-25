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

[Table("applicant_send_mail")]
public partial class ApplicantSendMail
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("template_id")]
    public Guid? TemplateId { get; set; }

    [Column("author_id")]
    public Guid? AuthorId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("lang")]
    public string? Lang { get; set; }

    [Column("subject")]
    public string? Subject { get; set; }

    [Column("body")]
    public string? Body { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("AuthorId")]
    [InverseProperty("ApplicantSendMails")]
    public virtual ResPartner? Author { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("ApplicantSendMailCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("TemplateId")]
    [InverseProperty("ApplicantSendMails")]
    public virtual MailTemplate? Template { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("ApplicantSendMailWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ApplicantSendMailId")]
    [InverseProperty("ApplicantSendMails")]
    [NotMapped]
    public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();
}
