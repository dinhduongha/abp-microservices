using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProductAttributeValue
{
    public Guid Id { get; set; }

    public long? Sequence { get; set; }

    public long? AttributeId { get; set; }

    public long? Color { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? HtmlColor { get; set; }

    public string? Name { get; set; }

    public bool? IsCustom { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ProductAttribute? Attribute { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; } = new List<ProductTemplateAttributeValue>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ProductTemplateAttributeLine> ProductTemplateAttributeLines { get; } = new List<ProductTemplateAttributeLine>();
}
