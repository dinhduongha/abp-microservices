using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class WebsitePage
{
    public Guid Id { get; set; }

    public Guid? WebsiteId { get; set; }

    public Guid? ViewId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public long? ThemeTemplateId { get; set; }

    public string? Url { get; set; }

    public string? HeaderColor { get; set; }

    public bool? IsPublished { get; set; }

    public bool? WebsiteIndexed { get; set; }

    public bool? HeaderOverlay { get; set; }

    public bool? HeaderVisible { get; set; }

    public bool? FooterVisible { get; set; }

    public DateTime? DatePublish { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrUiView? View { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ICollection<WebsiteMenu> WebsiteMenus { get; } = new List<WebsiteMenu>();

    public virtual ICollection<WebsiteTrack> WebsiteTracks { get; } = new List<WebsiteTrack>();

    public virtual ResUser? WriteU { get; set; }
}
