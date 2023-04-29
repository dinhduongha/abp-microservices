using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ThemeIrAsset
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Key { get; set; }

    public string? Name { get; set; }

    public string? Bundle { get; set; }

    public string? Directive { get; set; }

    public string? Path { get; set; }

    public string? Target { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
