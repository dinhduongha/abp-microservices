using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProductTemplateAttributeExclusion
{
    public Guid Id { get; set; }

    public Guid? ProductTemplateAttributeValueId { get; set; }

    public Guid? ProductTmplId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductTemplateAttributeValue? ProductTemplateAttributeValue { get; set; }

    public virtual ProductTemplate? ProductTmpl { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; } = new List<ProductTemplateAttributeValue>();
}
