using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProductTemplateAttributeExclusion
{
    public Guid Id { get; set; }

    public Guid? ProductTemplateAttributeValueId { get; set; }

    public Guid? ProductTmplId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductTemplateAttributeValue? ProductTemplateAttributeValue { get; set; }

    public virtual ProductTemplate? ProductTmpl { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; } = new List<ProductTemplateAttributeValue>();
}
