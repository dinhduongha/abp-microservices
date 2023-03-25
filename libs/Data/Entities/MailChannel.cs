using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("mail_channel")]
[Index("Uuid", Name = "mail_channel_uuid_unique", IsUnique = true)]
public partial class MailChannel
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("group_public_id")]
    public Guid? GroupPublicId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("channel_type")]
    public string? ChannelType { get; set; }

    [Column("default_display_mode")]
    public string? DefaultDisplayMode { get; set; }

    [Column("uuid")]
    public string? Uuid { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [InverseProperty("VideocallChannel")]
    [NotMapped]
    public virtual ICollection<CalendarEvent> CalendarEvents { get; } = new List<CalendarEvent>();

    [ForeignKey("CreatorId")]
    [InverseProperty("MailChannelCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("GroupPublicId")]
    [InverseProperty("MailChannels")]
    public virtual ResGroup? GroupPublic { get; set; }

    [InverseProperty("Channel")]
    [NotMapped]
    public virtual ICollection<MailChannelMember> MailChannelMembers { get; } = new List<MailChannelMember>();

    [InverseProperty("Channel")]
    [NotMapped]
    public virtual ICollection<MailChannelRtcSession> MailChannelRtcSessions { get; } = new List<MailChannelRtcSession>();

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("MailChannels")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("MailChannelWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("MailChannelId")]
    [InverseProperty("MailChannels")]
    [NotMapped]
    public virtual ICollection<HrDepartment> HrDepartments { get; } = new List<HrDepartment>();

    [ForeignKey("MailChannelId")]
    [InverseProperty("MailChannelsNavigation")]
    [NotMapped]
    public virtual ICollection<ResGroup> ResGroups { get; } = new List<ResGroup>();
}
