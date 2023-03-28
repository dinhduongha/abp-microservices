using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class PosOrderLine
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? OrderId { get; set; }

    public Guid? RefundedOrderlineId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Notice { get; set; }

    public string? FullProductName { get; set; }

    public string? CustomerNote { get; set; }

    public decimal? PriceUnit { get; set; }

    public decimal? Qty { get; set; }

    public decimal? PriceSubtotal { get; set; }

    public decimal? PriceSubtotalIncl { get; set; }

    public decimal? TotalCost { get; set; }

    public decimal? Discount { get; set; }

    public bool? IsTotalCostComputed { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? PriceExtra { get; set; }

    public Guid? SaleOrderOriginId { get; set; }

    public Guid? SaleOrderLineId { get; set; }

    public string? DownPaymentDetails { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<PosOrderLine> InverseRefundedOrderline { get; } = new List<PosOrderLine>();

    public virtual PosOrder? Order { get; set; }

    //public virtual ICollection<PosPackOperationLot> PosPackOperationLots { get; } = new List<PosPackOperationLot>();

    public virtual ProductProduct? Product { get; set; }

    public virtual PosOrderLine? RefundedOrderline { get; set; }

    public virtual SaleOrderLine? SaleOrderLine { get; set; }

    public virtual SaleOrder? SaleOrderOrigin { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();
}
