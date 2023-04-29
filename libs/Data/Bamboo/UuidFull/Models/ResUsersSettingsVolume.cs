using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ResUsersSettingsVolume
{
    public Guid Id { get; set; }

    public Guid? UserSettingId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? GuestId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? Volume { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Guest { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUsersSetting? UserSetting { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
