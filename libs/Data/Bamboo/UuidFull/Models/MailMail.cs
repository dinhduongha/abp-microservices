using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MailMail
{
    public Guid Id { get; set; }

    public Guid? MailMessageId { get; set; }

    public Guid? FetchmailServerId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? EmailCc { get; set; }

    public string? State { get; set; }

    public string? FailureType { get; set; }

    public string? BodyHtml { get; set; }

    public string? References { get; set; }

    public string? Headers { get; set; }

    public string? EmailTo { get; set; }

    public string? FailureReason { get; set; }

    public bool? IsNotification { get; set; }

    public bool? AutoDelete { get; set; }

    public bool? ToDelete { get; set; }

    public DateTime? ScheduledDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual FetchmailServer? FetchmailServer { get; set; }

    public virtual MailMessage? MailMessage { get; set; }

    public virtual ICollection<MailNotification> MailNotifications { get; } = new List<MailNotification>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();
}
