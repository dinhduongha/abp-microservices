using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class SmsResendRecipient
{
    public Guid Id { get; set; }

    public Guid? SmsResendId { get; set; }

    public Guid? NotificationId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? PartnerName { get; set; }

    public string? SmsNumber { get; set; }

    public bool? Resend { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailNotification? Notification { get; set; }

    public virtual SmsResend? SmsResend { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
