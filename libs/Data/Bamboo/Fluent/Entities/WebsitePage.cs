using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class WebsitePage
{
    public Guid Id { get; set; }

    public Guid? WebsiteId { get; set; }

    public Guid? ViewId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public long? ThemeTemplateId { get; set; }

    public string? Url { get; set; }

    public string? HeaderColor { get; set; }

    public bool? IsPublished { get; set; }

    public bool? WebsiteIndexed { get; set; }

    public bool? HeaderOverlay { get; set; }

    public bool? HeaderVisible { get; set; }

    public bool? FooterVisible { get; set; }

    public DateTime? DatePublish { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ThemeWebsitePage? ThemeTemplate { get; set; }

    public virtual IrUiView? View { get; set; }

    public virtual Website? Website { get; set; }

    //public virtual ICollection<WebsiteMenu> WebsiteMenus { get; } = new List<WebsiteMenu>();

    //public virtual ICollection<WebsiteTrack> WebsiteTracks { get; } = new List<WebsiteTrack>();

    public virtual ResUser? WriteU { get; set; }
}
