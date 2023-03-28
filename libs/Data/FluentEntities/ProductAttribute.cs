using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProductAttribute
{
    public long Id { get; set; }

    public long Sequence { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? CreateVariant { get; set; }

    public string? DisplayType { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? Visibility { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; } = new List<ProductAttributeValue>();

    //public virtual ICollection<ProductTemplateAttributeLine> ProductTemplateAttributeLines { get; } = new List<ProductTemplateAttributeLine>();

    //public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; } = new List<ProductTemplateAttributeValue>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();
}
