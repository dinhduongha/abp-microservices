using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProductImage
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? ProductTmplId { get; set; }

    public Guid? ProductVariantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? VideoUrl { get; set; }

    public bool? CanImage1024BeZoomed { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductTemplate? ProductTmpl { get; set; }

    public virtual ProductProduct? ProductVariant { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
