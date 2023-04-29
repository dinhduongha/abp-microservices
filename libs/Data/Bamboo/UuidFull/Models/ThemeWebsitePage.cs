using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ThemeWebsitePage
{
    public Guid Id { get; set; }

    public long? ViewId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Url { get; set; }

    public string? HeaderColor { get; set; }

    public bool? WebsiteIndexed { get; set; }

    public bool? IsPublished { get; set; }

    public bool? HeaderOverlay { get; set; }

    public bool? HeaderVisible { get; set; }

    public bool? FooterVisible { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
