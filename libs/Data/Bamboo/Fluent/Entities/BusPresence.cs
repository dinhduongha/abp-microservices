using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class BusPresence
{
    public long Id { get; set; }

    public Guid? UserId { get; set; }

    public string? Status { get; set; }

    public DateTime? LastPoll { get; set; }

    public DateTime? LastPresence { get; set; }

    public Guid? GuestId { get; set; }

    public virtual MailGuest? Guest { get; set; }

    public virtual ResUser? User { get; set; }
}
