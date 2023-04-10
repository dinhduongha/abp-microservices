using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ThemeWebsitePage
{
    public long Id { get; set; }

    public long? ViewId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Url { get; set; }

    public string? HeaderColor { get; set; }

    public bool? WebsiteIndexed { get; set; }

    public bool? IsPublished { get; set; }

    public bool? HeaderOverlay { get; set; }

    public bool? HeaderVisible { get; set; }

    public bool? FooterVisible { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<ThemeWebsiteMenu> ThemeWebsiteMenus { get; } = new List<ThemeWebsiteMenu>();

    public virtual ThemeIrUiView? View { get; set; }

    //public virtual ICollection<WebsitePage> WebsitePages { get; } = new List<WebsitePage>();

    public virtual ResUser? WriteU { get; set; }
}
