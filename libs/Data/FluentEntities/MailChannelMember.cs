using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailChannelMember
{
    public Guid Id { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? GuestId { get; set; }

    public Guid? ChannelId { get; set; }

    public Guid? FetchedMessageId { get; set; }

    public Guid? SeenMessageId { get; set; }

    public Guid? RtcInvitingSessionId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? CustomChannelName { get; set; }

    public string? FoldState { get; set; }

    public bool? IsMinimized { get; set; }

    public bool? IsPinned { get; set; }

    public DateTime? LastInterestDt { get; set; }

    public DateTime? LastSeenDt { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual MailChannel? Channel { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailMessage? FetchedMessage { get; set; }

    public virtual MailGuest? Guest { get; set; }

    public virtual MailChannelRtcSession? MailChannelRtcSession { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual MailChannelRtcSession? RtcInvitingSession { get; set; }

    public virtual MailMessage? SeenMessage { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
