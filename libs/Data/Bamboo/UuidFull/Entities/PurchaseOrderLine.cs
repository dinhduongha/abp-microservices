using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("purchase_order_line")]
[Index("DatePlanned", Name = "purchase_order_line_date_planned_index")]
[Index("OrderId", Name = "purchase_order_line_order_id_index")]
public partial class PurchaseOrderLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("product_uom")]
    public Guid? ProductUom { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("order_id")]
    public Guid? OrderId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("product_packaging_id")]
    public Guid? ProductPackagingId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("qty_received_method")]
    public string? QtyReceivedMethod { get; set; }

    [Column("display_type")]
    public string? DisplayType { get; set; }

    [Column("analytic_distribution", TypeName = "jsonb")]
    public string? AnalyticDistribution { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("product_qty")]
    public decimal? ProductQty { get; set; }

    [Column("price_unit")]
    public decimal? PriceUnit { get; set; }

    [Column("price_subtotal")]
    public decimal? PriceSubtotal { get; set; }

    [Column("price_total")]
    public decimal? PriceTotal { get; set; }

    [Column("qty_invoiced")]
    public decimal? QtyInvoiced { get; set; }

    [Column("qty_received")]
    public decimal? QtyReceived { get; set; }

    [Column("qty_received_manual")]
    public decimal? QtyReceivedManual { get; set; }

    [Column("qty_to_invoice")]
    public decimal? QtyToInvoice { get; set; }

    [Column("date_planned", TypeName = "timestamp without time zone")]
    public DateTime? DatePlanned { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("product_uom_qty")]
    public double? ProductUomQty { get; set; }

    [Column("price_tax")]
    public double? PriceTax { get; set; }

    [Column("product_packaging_qty")]
    public double? ProductPackagingQty { get; set; }

    [Column("orderpoint_id")]
    public Guid? OrderpointId { get; set; }

    [Column("product_description_variants")]
    public string? ProductDescriptionVariants { get; set; }

    [Column("propagate_cancel")]
    public bool? PropagateCancel { get; set; }

    [Column("sale_order_id")]
    public Guid? SaleOrderId { get; set; }

    [Column("sale_line_id")]
    public Guid? SaleLineId { get; set; }

    [InverseProperty("PurchaseLine")]
    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    [ForeignKey("CompanyId")]
    [InverseProperty("PurchaseOrderLines")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("PurchaseOrderLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("PurchaseOrderLines")]
    public virtual PurchaseOrder? Order { get; set; }

    [ForeignKey("OrderpointId")]
    [InverseProperty("PurchaseOrderLines")]
    public virtual StockWarehouseOrderpoint? Orderpoint { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("PurchaseOrderLines")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("PurchaseOrderLines")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("ProductPackagingId")]
    [InverseProperty("PurchaseOrderLines")]
    public virtual ProductPackaging? ProductPackaging { get; set; }

    [ForeignKey("ProductUom")]
    [InverseProperty("PurchaseOrderLines")]
    public virtual UomUom? ProductUomNavigation { get; set; }

    [ForeignKey("SaleLineId")]
    [InverseProperty("PurchaseOrderLines")]
    public virtual SaleOrderLine? SaleLine { get; set; }

    [ForeignKey("SaleOrderId")]
    [InverseProperty("PurchaseOrderLines")]
    public virtual SaleOrder? SaleOrder { get; set; }

    [InverseProperty("CreatedPurchaseLine")]
    public virtual ICollection<StockMove> StockMoveCreatedPurchaseLines { get; } = new List<StockMove>();

    [InverseProperty("PurchaseLine")]
    public virtual ICollection<StockMove> StockMovePurchaseLines { get; } = new List<StockMove>();

    [ForeignKey("WriteUid")]
    [InverseProperty("PurchaseOrderLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("PurchaseOrderLineId")]
    [InverseProperty("PurchaseOrderLines")]
    public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();
}
