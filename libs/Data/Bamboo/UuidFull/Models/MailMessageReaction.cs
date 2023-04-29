using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MailMessageReaction
{
    public Guid Id { get; set; }

    public Guid? MessageId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? GuestId { get; set; }

    public string? Content { get; set; }

    public virtual MailGuest? Guest { get; set; }

    public virtual MailMessage? Message { get; set; }

    public virtual ResPartner? Partner { get; set; }
}
