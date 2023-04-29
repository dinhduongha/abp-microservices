using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

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
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("message")]
    public string? Message { get; set; }

    [Column("resend")]
    public bool? Resend { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MailResendPartnerCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("MailResendPartners")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("ResendWizardId")]
    [InverseProperty("MailResendPartners")]
    public virtual MailResendMessage? ResendWizard { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MailResendPartnerWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
