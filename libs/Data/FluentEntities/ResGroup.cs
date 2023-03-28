using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ResGroup
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public Guid? CategoryId { get; set; }

    public long? Color { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Comment { get; set; }

    public bool? Share { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual IrModuleCategory? Category { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<DigestTip> DigestTips { get; } = new List<DigestTip>();

    //public virtual ICollection<IrModelAccess> IrModelAccesses { get; } = new List<IrModelAccess>();

    //public virtual ICollection<MailChannel> MailChannels { get; } = new List<MailChannel>();

    //public virtual ICollection<PosConfig> PosConfigGroupPosManagers { get; } = new List<PosConfig>();

    //public virtual ICollection<PosConfig> PosConfigGroupPosUsers { get; } = new List<PosConfig>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<IrActServer> Acts { get; } = new List<IrActServer>();

    //public virtual ICollection<IrActWindow> ActsNavigation { get; } = new List<IrActWindow>();

    //public virtual ICollection<IrModelField> Fields { get; } = new List<IrModelField>();

    //public virtual ICollection<ResGroup> Gids { get; } = new List<ResGroup>();

    //public virtual ICollection<ResGroup> Hids { get; } = new List<ResGroup>();

    //public virtual ICollection<MailChannel> MailChannelsNavigation { get; } = new List<MailChannel>();

    //public virtual ICollection<IrUiMenu> Menus { get; } = new List<IrUiMenu>();

    //public virtual ICollection<IrRule> RuleGroups { get; } = new List<IrRule>();

    //public virtual ICollection<SpreadsheetDashboard> SpreadsheetDashboards { get; } = new List<SpreadsheetDashboard>();

    //public virtual ICollection<IrActReportXml> Uids { get; } = new List<IrActReportXml>();

    //public virtual ICollection<ResUser> UidsNavigation { get; } = new List<ResUser>();

    //public virtual ICollection<IrUiView> Views { get; } = new List<IrUiView>();
}
