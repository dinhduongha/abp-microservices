using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class SnailmailLetterFormatError
{
    public Guid Id { get; set; }

    public Guid? MessageId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public bool? SnailmailCover { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailMessage? Message { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
