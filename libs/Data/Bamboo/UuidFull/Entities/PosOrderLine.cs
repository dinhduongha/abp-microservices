using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("pos_order_line")]
[Index("OrderId", Name = "pos_order_line_order_id_index")]
public partial class PosOrderLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("order_id")]
    public Guid? OrderId { get; set; }

    [Column("refunded_orderline_id")]
    public Guid? RefundedOrderlineId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("notice")]
    public string? Notice { get; set; }

    [Column("full_product_name")]
    public string? FullProductName { get; set; }

    [Column("customer_note")]
    public string? CustomerNote { get; set; }

    [Column("price_unit")]
    public decimal? PriceUnit { get; set; }

    [Column("qty")]
    public decimal? Qty { get; set; }

    [Column("price_subtotal")]
    public decimal? PriceSubtotal { get; set; }

    [Column("price_subtotal_incl")]
    public decimal? PriceSubtotalIncl { get; set; }

    [Column("total_cost")]
    public decimal? TotalCost { get; set; }

    [Column("discount")]
    public decimal? Discount { get; set; }

    [Column("is_total_cost_computed")]
    public bool? IsTotalCostComputed { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("price_extra")]
    public double? PriceExtra { get; set; }

    [Column("sale_order_origin_id")]
    public Guid? SaleOrderOriginId { get; set; }

    [Column("sale_order_line_id")]
    public Guid? SaleOrderLineId { get; set; }

    [Column("down_payment_details")]
    public string? DownPaymentDetails { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("PosOrderLines")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("PosOrderLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("RefundedOrderline")]
    public virtual ICollection<PosOrderLine> InverseRefundedOrderline { get; } = new List<PosOrderLine>();

    [ForeignKey("OrderId")]
    [InverseProperty("PosOrderLines")]
    public virtual PosOrder? Order { get; set; }

    [InverseProperty("PosOrderLine")]
    public virtual ICollection<PosPackOperationLot> PosPackOperationLots { get; } = new List<PosPackOperationLot>();

    [ForeignKey("ProductId")]
    [InverseProperty("PosOrderLines")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("RefundedOrderlineId")]
    [InverseProperty("InverseRefundedOrderline")]
    public virtual PosOrderLine? RefundedOrderline { get; set; }

    [ForeignKey("SaleOrderLineId")]
    [InverseProperty("PosOrderLines")]
    public virtual SaleOrderLine? SaleOrderLine { get; set; }

    [ForeignKey("SaleOrderOriginId")]
    [InverseProperty("PosOrderLines")]
    public virtual SaleOrder? SaleOrderOrigin { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("PosOrderLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("PosOrderLineId")]
    [InverseProperty("PosOrderLines")]
    public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();
}
