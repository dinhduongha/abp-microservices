using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mail_resend_message")]
public partial class MailResendMessage
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("mail_message_id")]
    public Guid? MailMessageId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MailResendMessageCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MailMessageId")]
    [InverseProperty("MailResendMessages")]
    public virtual MailMessage? MailMessage { get; set; }

    [InverseProperty("ResendWizard")]
    public virtual ICollection<MailResendPartner> MailResendPartners { get; } = new List<MailResendPartner>();

    [ForeignKey("WriteUid")]
    [InverseProperty("MailResendMessageWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("MailResendMessageId")]
    [InverseProperty("MailResendMessages")]
    public virtual ICollection<MailNotification> MailNotifications { get; } = new List<MailNotification>();
}
