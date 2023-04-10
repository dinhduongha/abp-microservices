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

[Table("mail_resend_partner")]
public partial class MailResendPartner
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("resend_wizard_id")]
    public Guid? ResendWizardId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("message")]
    public string? Message { get; set; }

    [Column("resend")]
    public bool? Resend { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("MailResendPartnerCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PartnerId")]
    //[InverseProperty("MailResendPartners")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("ResendWizardId")]
    //[InverseProperty("MailResendPartners")]
    public virtual MailResendMessage? ResendWizard { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("MailResendPartnerWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
