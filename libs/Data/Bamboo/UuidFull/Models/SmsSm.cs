using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class SmsSm
{
    public Guid Id { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? MailMessageId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Number { get; set; }

    public string? State { get; set; }

    public string? FailureType { get; set; }

    public string? Body { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailMessage? MailMessage { get; set; }

    public virtual ICollection<MailNotification> MailNotifications { get; } = new List<MailNotification>();

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
