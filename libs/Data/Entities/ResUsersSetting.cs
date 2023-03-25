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

[Table("res_users_settings")]
[Index("UserId", Name = "res_users_settings_unique_user_id", IsUnique = true)]
public partial class ResUsersSetting
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("voice_active_duration")]
    public long? VoiceActiveDuration { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("push_to_talk_key")]
    public string? PushToTalkKey { get; set; }

    [Column("is_discuss_sidebar_category_channel_open")]
    public bool? IsDiscussSidebarCategoryChannelOpen { get; set; }

    [Column("is_discuss_sidebar_category_chat_open")]
    public bool? IsDiscussSidebarCategoryChatOpen { get; set; }

    [Column("use_push_to_talk")]
    public bool? UsePushToTalk { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("ResUsersSettingCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("UserSetting")]
    public virtual ICollection<ResUsersSettingsVolume> ResUsersSettingsVolumes { get; } = new List<ResUsersSettingsVolume>();

    [ForeignKey("UserId")]
    [InverseProperty("ResUsersSettingUser")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("ResUsersSettingWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
