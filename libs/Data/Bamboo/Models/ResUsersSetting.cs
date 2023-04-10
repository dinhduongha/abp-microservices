using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ResUsersSetting
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public long? VoiceActiveDuration { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? PushToTalkKey { get; set; }

    public bool? IsDiscussSidebarCategoryChannelOpen { get; set; }

    public bool? IsDiscussSidebarCategoryChatOpen { get; set; }

    public bool? UsePushToTalk { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<ResUsersSettingsVolume> ResUsersSettingsVolumes { get; } = new List<ResUsersSettingsVolume>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
