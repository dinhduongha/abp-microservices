using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailNotification
{
    public Guid Id { get; set; }

    public Guid? AuthorId { get; set; }

    public Guid? MailMessageId { get; set; }

    public Guid? MailMailId { get; set; }

    public Guid? ResPartnerId { get; set; }

    public string? NotificationType { get; set; }

    public string? NotificationStatus { get; set; }

    public string? FailureType { get; set; }

    public string? FailureReason { get; set; }

    public bool? IsRead { get; set; }

    public DateTime? ReadDate { get; set; }

    public Guid? SmsId { get; set; }

    public string? SmsNumber { get; set; }

    public Guid? LetterId { get; set; }

    public virtual ResPartner? Author { get; set; }

    public virtual SnailmailLetter? Letter { get; set; }

    public virtual MailMail? MailMail { get; set; }

    public virtual MailMessage? MailMessage { get; set; }

    public virtual ResPartner? ResPartner { get; set; }

    public virtual SmsSm? Sms { get; set; }

    //public virtual ICollection<SmsResendRecipient> SmsResendRecipients { get; } = new List<SmsResendRecipient>();

    //public virtual ICollection<MailResendMessage> MailResendMessages { get; } = new List<MailResendMessage>();
}
