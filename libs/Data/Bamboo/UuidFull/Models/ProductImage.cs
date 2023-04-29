using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProductImage
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? ProductTmplId { get; set; }

    public Guid? ProductVariantId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? VideoUrl { get; set; }

    public bool? CanImage1024BeZoomed { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductTemplate? ProductTmpl { get; set; }

    public virtual ProductProduct? ProductVariant { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
