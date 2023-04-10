using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class SnailmailLetterFormatError
{
    public Guid Id { get; set; }

    public Guid? MessageId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? SnailmailCover { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailMessage? Message { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
