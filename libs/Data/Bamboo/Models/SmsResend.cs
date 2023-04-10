using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class SmsResend
{
    public Guid Id { get; set; }

    public Guid? MailMessageId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailMessage? MailMessage { get; set; }

    //public virtual ICollection<SmsResendRecipient> SmsResendRecipients { get; } = new List<SmsResendRecipient>();

    public virtual ResUser? WriteU { get; set; }
}
