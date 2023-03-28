using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrAsset
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Bundle { get; set; }

    public string? Directive { get; set; }

    public string? Path { get; set; }

    public string? Target { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? WebsiteId { get; set; }

    public long? ThemeTemplateId { get; set; }

    public string? Key { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ThemeIrAsset? ThemeTemplate { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
