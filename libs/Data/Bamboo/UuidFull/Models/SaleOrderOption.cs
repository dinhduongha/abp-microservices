using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class SaleOrderOption
{
    public Guid Id { get; set; }

    public Guid? OrderId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? LineId { get; set; }

    public long Sequence { get; set; }

    public Guid? UomId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? PriceUnit { get; set; }

    public decimal? Discount { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual SaleOrderLine? Line { get; set; }

    public virtual SaleOrder? Order { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? Uom { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
