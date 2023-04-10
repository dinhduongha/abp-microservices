using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class SmsSm
{
    public Guid Id { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? MailMessageId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Number { get; set; }

    public string? State { get; set; }

    public string? FailureType { get; set; }

    public string? Body { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailMessage? MailMessage { get; set; }

    //public virtual ICollection<MailNotification> MailNotifications { get; } = new List<MailNotification>();

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
