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

[Table("mail_resend_message")]
public partial class MailResendMessage
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("mail_message_id")]
    public Guid? MailMessageId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("MailResendMessageCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MailMessageId")]
    [InverseProperty("MailResendMessages")]
    public virtual MailMessage? MailMessage { get; set; }

    [InverseProperty("ResendWizard")]
    public virtual ICollection<MailResendPartner> MailResendPartners { get; } = new List<MailResendPartner>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("MailResendMessageWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("MailResendMessageId")]
    [InverseProperty("MailResendMessages")]
    public virtual ICollection<MailNotification> MailNotifications { get; } = new List<MailNotification>();
}
