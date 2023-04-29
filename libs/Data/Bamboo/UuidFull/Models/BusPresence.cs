using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class BusPresence
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public string? Status { get; set; }

    public DateTime? LastPoll { get; set; }

    public DateTime? LastPresence { get; set; }

    public Guid? GuestId { get; set; }

    public virtual MailGuest? Guest { get; set; }

    public virtual ResUser? User { get; set; }
}
