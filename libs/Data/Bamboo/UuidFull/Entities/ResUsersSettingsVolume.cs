using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("res_users_settings_volumes")]
[Index("GuestId", Name = "res_users_settings_volumes_guest_id_index")]
[Index("PartnerId", Name = "res_users_settings_volumes_partner_id_index")]
[Index("UserSettingId", Name = "res_users_settings_volumes_user_setting_id_index")]
public partial class ResUsersSettingsVolume
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("user_setting_id")]
    public Guid? UserSettingId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("guest_id")]
    public Guid? GuestId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("volume")]
    public double? Volume { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ResUsersSettingsVolumeCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("GuestId")]
    [InverseProperty("ResUsersSettingsVolumeGuests")]
    public virtual ResPartner? Guest { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("ResUsersSettingsVolumePartners")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("UserSettingId")]
    [InverseProperty("ResUsersSettingsVolumes")]
    public virtual ResUsersSetting? UserSetting { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ResUsersSettingsVolumeWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
