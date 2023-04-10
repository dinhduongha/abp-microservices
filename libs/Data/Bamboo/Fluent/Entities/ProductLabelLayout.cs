using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProductLabelLayout
{
    public Guid Id { get; set; }

    public long? CustomQuantity { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? PrintFormat { get; set; }

    public string? ExtraHtml { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? PickingQuantity { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ProductProduct> ProductProducts { get; } = new List<ProductProduct>();

    //public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();

    //public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();
}
