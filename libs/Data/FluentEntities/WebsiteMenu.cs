using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class WebsiteMenu
{
    public Guid Id { get; set; }

    public Guid? PageId { get; set; }

    public long Sequence { get; set; }

    public Guid? WebsiteId { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public long? ThemeTemplateId { get; set; }

    public string? Url { get; set; }

    public string? ParentPath { get; set; }

    public string? MegaMenuClasses { get; set; }

    public string? Name { get; set; }

    public string? MegaMenuContent { get; set; }

    public bool? NewWindow { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<WebsiteMenu> InverseParent { get; } = new List<WebsiteMenu>();

    public virtual WebsitePage? Page { get; set; }

    public virtual WebsiteMenu? Parent { get; set; }

    public virtual ThemeWebsiteMenu? ThemeTemplate { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
