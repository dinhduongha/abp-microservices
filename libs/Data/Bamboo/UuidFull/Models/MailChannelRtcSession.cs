using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MailChannelRtcSession
{
    public Guid Id { get; set; }

    public Guid? ChannelMemberId { get; set; }

    public Guid? ChannelId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public bool? IsScreenSharingOn { get; set; }

    public bool? IsCameraOn { get; set; }

    public bool? IsMuted { get; set; }

    public bool? IsDeaf { get; set; }

    public DateTime? WriteDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual MailChannel? Channel { get; set; }

    public virtual MailChannelMember? ChannelMember { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MailChannelMember> MailChannelMembers { get; } = new List<MailChannelMember>();

    public virtual ResUser? WriteU { get; set; }
}
