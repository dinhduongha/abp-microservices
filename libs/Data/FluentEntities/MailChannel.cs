using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailChannel
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? GroupPublicId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? ChannelType { get; set; }

    public string? DefaultDisplayMode { get; set; }

    public string? Uuid { get; set; }

    public string? Description { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<CalendarEvent> CalendarEvents { get; } = new List<CalendarEvent>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResGroup? GroupPublic { get; set; }

    //public virtual ICollection<MailChannelMember> MailChannelMembers { get; } = new List<MailChannelMember>();

    //public virtual ICollection<MailChannelRtcSession> MailChannelRtcSessions { get; } = new List<MailChannelRtcSession>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<HrDepartment> HrDepartments { get; } = new List<HrDepartment>();

    //public virtual ICollection<ResGroup> ResGroups { get; } = new List<ResGroup>();
}
