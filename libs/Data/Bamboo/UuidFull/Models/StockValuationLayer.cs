﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockValuationLayer
{
    public Guid Id { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? StockValuationLayerId { get; set; }

    public Guid? StockMoveId { get; set; }

    public Guid? AccountMoveId { get; set; }

    public Guid? AccountMoveLineId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Description { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? UnitCost { get; set; }

    public decimal? Value { get; set; }

    public decimal? RemainingQty { get; set; }

    public decimal? RemainingValue { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? PriceDiffValue { get; set; }

    public virtual AccountMove? AccountMove { get; set; }

    public virtual AccountMoveLine? AccountMoveLine { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<StockValuationLayer> InverseStockValuationLayerNavigation { get; } = new List<StockValuationLayer>();

    public virtual ProductProduct? Product { get; set; }

    public virtual StockMove? StockMove { get; set; }

    public virtual StockValuationLayer? StockValuationLayerNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
