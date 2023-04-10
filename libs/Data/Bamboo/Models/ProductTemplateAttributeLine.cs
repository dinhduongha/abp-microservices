using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProductTemplateAttributeLine
{
    public Guid Id { get; set; }

    public Guid? ProductTmplId { get; set; }

    public long? AttributeId { get; set; }

    public long? ValueCount { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ProductAttribute? Attribute { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; } = new List<ProductTemplateAttributeValue>();

    public virtual ProductTemplate? ProductTmpl { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; } = new List<ProductAttributeValue>();
}
