using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProductAttributeValue
{
    public Guid Id { get; set; }

    public long? Sequence { get; set; }

    public long? AttributeId { get; set; }

    public long? Color { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? HtmlColor { get; set; }

    public string? Name { get; set; }

    public bool? IsCustom { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; } = new List<ProductTemplateAttributeValue>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProductTemplateAttributeLine> ProductTemplateAttributeLines { get; } = new List<ProductTemplateAttributeLine>();
}
