using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class SmsResend
{
    public Guid Id { get; set; }

    public Guid? MailMessageId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailMessage? MailMessage { get; set; }

    public virtual ICollection<SmsResendRecipient> SmsResendRecipients { get; } = new List<SmsResendRecipient>();

    public virtual ResUser? WriteU { get; set; }
}
