using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProductAttributeCustomValue
{
    public Guid Id { get; set; }

    public Guid? CustomProductTemplateAttributeValueId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? CustomValue { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? SaleOrderLineId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductTemplateAttributeValue? CustomProductTemplateAttributeValue { get; set; }

    public virtual SaleOrderLine? SaleOrderLine { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
