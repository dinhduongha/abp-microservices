using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockChangeProductQty
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? ProductTmplId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public decimal? NewQuantity { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ProductTemplate? ProductTmpl { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
