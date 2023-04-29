﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MailGuest
{
    public Guid Id { get; set; }

    public long? CountryId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? AccessToken { get; set; }

    public string? Lang { get; set; }

    public string? Timezone { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual BusPresence? BusPresence { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MailChannelMember> MailChannelMembers { get; } = new List<MailChannelMember>();

    public virtual ICollection<MailMessageReaction> MailMessageReactions { get; } = new List<MailMessageReaction>();

    public virtual ICollection<MailMessage> MailMessages { get; } = new List<MailMessage>();

    public virtual ResUser? WriteU { get; set; }
}
