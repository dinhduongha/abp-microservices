using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ThemeIrAsset
{
    public long Id { get; set; }

    public long Sequence { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Key { get; set; }

    public string? Name { get; set; }

    public string? Bundle { get; set; }

    public string? Directive { get; set; }

    public string? Path { get; set; }

    public string? Target { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<IrAsset> IrAssets { get; } = new List<IrAsset>();

    public virtual ResUser? WriteU { get; set; }
}
