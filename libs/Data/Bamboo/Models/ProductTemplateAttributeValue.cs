using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProductTemplateAttributeValue
{
    public Guid Id { get; set; }

    public Guid? ProductAttributeValueId { get; set; }

    public Guid? AttributeLineId { get; set; }

    public Guid? ProductTmplId { get; set; }

    public long? AttributeId { get; set; }

    public long? Color { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public decimal? PriceExtra { get; set; }

    public bool? PtavActive { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ProductAttribute? Attribute { get; set; }

    public virtual ProductTemplateAttributeLine? AttributeLine { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<ProductAttributeCustomValue> ProductAttributeCustomValues { get; } = new List<ProductAttributeCustomValue>();

    public virtual ProductAttributeValue? ProductAttributeValue { get; set; }

    //public virtual ICollection<ProductTemplateAttributeExclusion> ProductTemplateAttributeExclusionsNavigation { get; } = new List<ProductTemplateAttributeExclusion>();

    public virtual ProductTemplate? ProductTmpl { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<MrpBomByproduct> MrpBomByproducts { get; } = new List<MrpBomByproduct>();

    //public virtual ICollection<MrpBomLine> MrpBomLines { get; } = new List<MrpBomLine>();

    //public virtual ICollection<MrpRoutingWorkcenter> MrpRoutingWorkcenters { get; } = new List<MrpRoutingWorkcenter>();

    //public virtual ICollection<ProductProduct> ProductProducts { get; } = new List<ProductProduct>();

    //public virtual ICollection<ProductTemplateAttributeExclusion> ProductTemplateAttributeExclusions { get; } = new List<ProductTemplateAttributeExclusion>();

    //public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();
}
