using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mail_mail")]
[Index("MailMessageId", Name = "mail_mail_mail_message_id_index")]
public partial class MailMail
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("mail_message_id")]
    public Guid? MailMessageId { get; set; }

    [Column("fetchmail_server_id")]
    public Guid? FetchmailServerId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("email_cc")]
    public string? EmailCc { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("failure_type")]
    public string? FailureType { get; set; }

    [Column("body_html")]
    public string? BodyHtml { get; set; }

    [Column("references")]
    public string? References { get; set; }

    [Column("headers")]
    public string? Headers { get; set; }

    [Column("email_to")]
    public string? EmailTo { get; set; }

    [Column("failure_reason")]
    public string? FailureReason { get; set; }

    [Column("is_notification")]
    public bool? IsNotification { get; set; }

    [Column("auto_delete")]
    public bool? AutoDelete { get; set; }

    [Column("to_delete")]
    public bool? ToDelete { get; set; }

    [Column("scheduled_date", TypeName = "timestamp without time zone")]
    public DateTime? ScheduledDate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MailMailCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("FetchmailServerId")]
    [InverseProperty("MailMails")]
    public virtual FetchmailServer? FetchmailServer { get; set; }

    [ForeignKey("MailMessageId")]
    [InverseProperty("MailMails")]
    public virtual MailMessage? MailMessage { get; set; }

    [InverseProperty("MailMail")]
    public virtual ICollection<MailNotification> MailNotifications { get; } = new List<MailNotification>();

    [ForeignKey("WriteUid")]
    [InverseProperty("MailMailWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("MailMailId")]
    [InverseProperty("MailMails")]
    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();
}
