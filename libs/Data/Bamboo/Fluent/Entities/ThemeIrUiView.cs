using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ThemeIrUiView
{
    public long Id { get; set; }

    public long? Priority { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Key { get; set; }

    public string? Type { get; set; }

    public string? Mode { get; set; }

    public string? ArchFs { get; set; }

    public string? InheritId { get; set; }

    public string? Arch { get; set; }

    public bool? Active { get; set; }

    public bool? CustomizeShow { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<IrUiView> IrUiViews { get; } = new List<IrUiView>();

    //public virtual ICollection<ThemeWebsitePage> ThemeWebsitePages { get; } = new List<ThemeWebsitePage>();

    public virtual ResUser? WriteU { get; set; }
}
