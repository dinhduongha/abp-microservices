using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ThemeWebsiteMenu
{
    public Guid Id { get; set; }

    public long? PageId { get; set; }

    public long Sequence { get; set; }

    public long? ParentId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Url { get; set; }

    public string? MegaMenuClasses { get; set; }

    public string? Name { get; set; }

    public string? MegaMenuContent { get; set; }

    public bool? NewWindow { get; set; }

    public bool? UseMainMenuAsParent { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
