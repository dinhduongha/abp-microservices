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

[Table("res_groups")]
[Index("CategoryId", Name = "res_groups_category_id_index")]
[Index("CategoryId", "Name", Name = "res_groups_name_uniq", IsUnique = true)]
public partial class ResGroup
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("category_id")]
    public Guid? CategoryId { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("comment", TypeName = "jsonb")]
    public string? Comment { get; set; }

    [Column("share")]
    public bool? Share { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("ResGroups")]
    public virtual IrModuleCategory? Category { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("ResGroupCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Group")]
    public virtual ICollection<DigestTip> DigestTips { get; } = new List<DigestTip>();

    [InverseProperty("Group")]
    public virtual ICollection<IrModelAccess> IrModelAccesses { get; } = new List<IrModelAccess>();

    [InverseProperty("GroupPublic")]
    public virtual ICollection<MailChannel> MailChannels { get; } = new List<MailChannel>();

    [InverseProperty("GroupPosManager")]
    public virtual ICollection<PosConfig> PosConfigGroupPosManagers { get; } = new List<PosConfig>();

    [InverseProperty("GroupPosUser")]
    public virtual ICollection<PosConfig> PosConfigGroupPosUsers { get; } = new List<PosConfig>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("ResGroupWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("Gid")]
    [InverseProperty("Gids")]
    public virtual ICollection<IrActServer> Acts { get; } = new List<IrActServer>();

    [ForeignKey("Gid")]
    [InverseProperty("Gids")]
    public virtual ICollection<IrActWindow> ActsNavigation { get; } = new List<IrActWindow>();

    [ForeignKey("GroupId")]
    [InverseProperty("Groups")]
    public virtual ICollection<IrModelField> Fields { get; } = new List<IrModelField>();

    [ForeignKey("Hid")]
    [InverseProperty("Hids")]
    public virtual ICollection<ResGroup> Gids { get; } = new List<ResGroup>();

    [ForeignKey("Gid")]
    [InverseProperty("Gids")]
    public virtual ICollection<ResGroup> Hids { get; } = new List<ResGroup>();

    [ForeignKey("ResGroupsId")]
    [InverseProperty("ResGroups")]
    public virtual ICollection<MailChannel> MailChannelsNavigation { get; } = new List<MailChannel>();

    [ForeignKey("Gid")]
    [InverseProperty("Gids")]
    public virtual ICollection<IrUiMenu> Menus { get; } = new List<IrUiMenu>();

    [ForeignKey("GroupId")]
    [InverseProperty("Groups")]
    public virtual ICollection<IrRule> RuleGroups { get; } = new List<IrRule>();

    [ForeignKey("ResGroupsId")]
    [InverseProperty("ResGroups")]
    public virtual ICollection<SpreadsheetDashboard> SpreadsheetDashboards { get; } = new List<SpreadsheetDashboard>();

    [ForeignKey("Gid")]
    [InverseProperty("Gids")]
    public virtual ICollection<IrActReportXml> Uids { get; } = new List<IrActReportXml>();

    [ForeignKey("Gid")]
    [InverseProperty("Gids")]
    public virtual ICollection<ResUser> UidsNavigation { get; } = new List<ResUser>();

    [ForeignKey("GroupId")]
    [InverseProperty("Groups")]
    public virtual ICollection<IrUiView> Views { get; } = new List<IrUiView>();
}
