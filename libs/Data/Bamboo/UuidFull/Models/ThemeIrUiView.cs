using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ThemeIrUiView
{
    public Guid Id { get; set; }

    public long? Priority { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Key { get; set; }

    public string? Type { get; set; }

    public string? Mode { get; set; }

    public string? ArchFs { get; set; }

    public string? InheritId { get; set; }

    public string? Arch { get; set; }

    public bool? Active { get; set; }

    public bool? CustomizeShow { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
