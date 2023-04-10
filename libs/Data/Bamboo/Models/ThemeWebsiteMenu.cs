using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ThemeWebsiteMenu
{
    public long Id { get; set; }

    public long? PageId { get; set; }

    public long Sequence { get; set; }

    public long? ParentId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Url { get; set; }

    public string? MegaMenuClasses { get; set; }

    public string? Name { get; set; }

    public string? MegaMenuContent { get; set; }

    public bool? NewWindow { get; set; }

    public bool? UseMainMenuAsParent { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<ThemeWebsiteMenu> InverseParent { get; } = new List<ThemeWebsiteMenu>();

    public virtual ThemeWebsitePage? Page { get; set; }

    public virtual ThemeWebsiteMenu? Parent { get; set; }

    //public virtual ICollection<WebsiteMenu> WebsiteMenus { get; } = new List<WebsiteMenu>();

    public virtual ResUser? WriteU { get; set; }
}
