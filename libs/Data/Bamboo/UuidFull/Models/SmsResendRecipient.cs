using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class SmsResendRecipient
{
    public Guid Id { get; set; }

    public Guid? SmsResendId { get; set; }

    public Guid? NotificationId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? PartnerName { get; set; }

    public string? SmsNumber { get; set; }

    public bool? Resend { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailNotification? Notification { get; set; }

    public virtual SmsResend? SmsResend { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
