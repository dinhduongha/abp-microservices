using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ResUsersSettingsVolume
{
    public Guid Id { get; set; }

    public Guid? UserSettingId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? GuestId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? Volume { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Guest { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUsersSetting? UserSetting { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
