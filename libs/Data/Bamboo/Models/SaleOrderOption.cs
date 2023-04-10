using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class SaleOrderOption
{
    public Guid Id { get; set; }

    public Guid? OrderId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? LineId { get; set; }

    public long Sequence { get; set; }

    public Guid? UomId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? PriceUnit { get; set; }

    public decimal? Discount { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual SaleOrderLine? Line { get; set; }

    public virtual SaleOrder? Order { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? Uom { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
