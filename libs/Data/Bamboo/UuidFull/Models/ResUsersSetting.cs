using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ResUsersSetting
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public long? VoiceActiveDuration { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? PushToTalkKey { get; set; }

    public bool? IsDiscussSidebarCategoryChannelOpen { get; set; }

    public bool? IsDiscussSidebarCategoryChatOpen { get; set; }

    public bool? UsePushToTalk { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ResUsersSettingsVolume> ResUsersSettingsVolumes { get; } = new List<ResUsersSettingsVolume>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
