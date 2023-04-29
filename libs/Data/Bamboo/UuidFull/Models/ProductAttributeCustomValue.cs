using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProductAttributeCustomValue
{
    public Guid Id { get; set; }

    public Guid? CustomProductTemplateAttributeValueId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? CustomValue { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? SaleOrderLineId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductTemplateAttributeValue? CustomProductTemplateAttributeValue { get; set; }

    public virtual SaleOrderLine? SaleOrderLine { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
