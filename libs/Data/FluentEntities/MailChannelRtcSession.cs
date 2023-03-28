using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailChannelRtcSession
{
    public Guid Id { get; set; }

    public Guid? ChannelMemberId { get; set; }

    public Guid? ChannelId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? IsScreenSharingOn { get; set; }

    public bool? IsCameraOn { get; set; }

    public bool? IsMuted { get; set; }

    public bool? IsDeaf { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public DateTime? CreationTime { get; set; }

    public virtual MailChannel? Channel { get; set; }

    public virtual MailChannelMember? ChannelMember { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<MailChannelMember> MailChannelMembers { get; } = new List<MailChannelMember>();

    public virtual ResUser? WriteU { get; set; }
}
