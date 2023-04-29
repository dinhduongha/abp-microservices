using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mail_channel_rtc_session")]
[Index("ChannelMemberId", Name = "mail_channel_rtc_session_channel_member_unique", IsUnique = true)]
[Index("WriteDate", Name = "mail_channel_rtc_session_write_date_index")]
public partial class MailChannelRtcSession
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("channel_member_id")]
    public Guid? ChannelMemberId { get; set; }

    [Column("channel_id")]
    public Guid? ChannelId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("is_screen_sharing_on")]
    public bool? IsScreenSharingOn { get; set; }

    [Column("is_camera_on")]
    public bool? IsCameraOn { get; set; }

    [Column("is_muted")]
    public bool? IsMuted { get; set; }

    [Column("is_deaf")]
    public bool? IsDeaf { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [ForeignKey("ChannelId")]
    [InverseProperty("MailChannelRtcSessions")]
    public virtual MailChannel? Channel { get; set; }

    [ForeignKey("ChannelMemberId")]
    [InverseProperty("MailChannelRtcSession")]
    public virtual MailChannelMember? ChannelMember { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MailChannelRtcSessionCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("RtcInvitingSession")]
    public virtual ICollection<MailChannelMember> MailChannelMembers { get; } = new List<MailChannelMember>();

    [ForeignKey("WriteUid")]
    [InverseProperty("MailChannelRtcSessionWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
