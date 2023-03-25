﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("sale_order_line")]
[Index("TenantId", Name = "sale_order_line_company_id_index")]
[Index("LinkedLineId", Name = "sale_order_line_linked_line_id_index")]
[Index("OrderId", Name = "sale_order_line_order_id_index")]
[Index("OrderPartnerId", Name = "sale_order_line_order_partner_id_index")]
[Index("ProjectId", Name = "sale_order_line_project_id_index")]
[Index("TaskId", Name = "sale_order_line_task_id_index")]
public partial class SaleOrderLine: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("order_id")]
    public Guid? OrderId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("order_partner_id")]
    public Guid? OrderPartnerId { get; set; }

    [Column("salesman_id")]
    public Guid? SalesmanId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("product_uom")]
    public Guid? ProductUom { get; set; }

    [Column("product_packaging_id")]
    public Guid? ProductPackagingId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("display_type")]
    public string? DisplayType { get; set; }

    [Column("qty_delivered_method")]
    public string? QtyDeliveredMethod { get; set; }

    [Column("invoice_status")]
    public string? InvoiceStatus { get; set; }

    [Column("analytic_distribution", TypeName = "jsonb")]
    public string? AnalyticDistribution { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("product_uom_qty")]
    public decimal? ProductUomQty { get; set; }

    [Column("price_unit")]
    public decimal? PriceUnit { get; set; }

    [Column("discount")]
    public decimal? Discount { get; set; }

    [Column("price_reduce")]
    public decimal? PriceReduce { get; set; }

    [Column("price_subtotal")]
    public decimal? PriceSubtotal { get; set; }

    [Column("price_total")]
    public decimal? PriceTotal { get; set; }

    [Column("price_reduce_taxexcl")]
    public decimal? PriceReduceTaxexcl { get; set; }

    [Column("price_reduce_taxinc")]
    public decimal? PriceReduceTaxinc { get; set; }

    [Column("qty_delivered")]
    public decimal? QtyDelivered { get; set; }

    [Column("qty_invoiced")]
    public decimal? QtyInvoiced { get; set; }

    [Column("qty_to_invoice")]
    public decimal? QtyToInvoice { get; set; }

    [Column("untaxed_amount_invoiced")]
    public decimal? UntaxedAmountInvoiced { get; set; }

    [Column("untaxed_amount_to_invoice")]
    public decimal? UntaxedAmountToInvoice { get; set; }

    [Column("is_downpayment")]
    public bool? IsDownpayment { get; set; }

    [Column("is_expense")]
    public bool? IsExpense { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("price_tax")]
    public double? PriceTax { get; set; }

    [Column("product_packaging_qty")]
    public double? ProductPackagingQty { get; set; }

    [Column("customer_lead")]
    public double? CustomerLead { get; set; }

    [Column("route_id")]
    public Guid? RouteId { get; set; }

    [Column("is_service")]
    public bool? IsService { get; set; }

    [Column("project_id")]
    public Guid? ProjectId { get; set; }

    [Column("task_id")]
    public Guid? TaskId { get; set; }

    [Column("linked_line_id")]
    public Guid? LinkedLineId { get; set; }

    [Column("shop_warning")]
    public string? ShopWarning { get; set; }

    [InverseProperty("SoLineNavigation")]
    [NotMapped]
    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    [ForeignKey("TenantId")]
    [InverseProperty("SaleOrderLines")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("SaleOrderLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CurrencyId")]
    [InverseProperty("SaleOrderLines")]
    public virtual ResCurrency? Currency { get; set; }

    [InverseProperty("LinkedLine")]
    [NotMapped]
    public virtual ICollection<SaleOrderLine> InverseLinkedLine { get; } = new List<SaleOrderLine>();

    [ForeignKey("LinkedLineId")]
    [InverseProperty("InverseLinkedLine")]
    public virtual SaleOrderLine? LinkedLine { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("SaleOrderLines")]
    public virtual SaleOrder? Order { get; set; }

    [ForeignKey("OrderPartnerId")]
    [InverseProperty("SaleOrderLines")]
    public virtual ResPartner? OrderPartner { get; set; }

    [InverseProperty("SaleOrderLine")]
    [NotMapped]
    public virtual ICollection<PosOrderLine> PosOrderLines { get; } = new List<PosOrderLine>();

    [ForeignKey("ProductId")]
    [InverseProperty("SaleOrderLines")]
    public virtual ProductProduct? Product { get; set; }

    [InverseProperty("SaleOrderLine")]
    [NotMapped]
    public virtual ICollection<ProductAttributeCustomValue> ProductAttributeCustomValues { get; } = new List<ProductAttributeCustomValue>();

    [ForeignKey("ProductPackagingId")]
    [InverseProperty("SaleOrderLines")]
    public virtual ProductPackaging? ProductPackaging { get; set; }

    [ForeignKey("ProductUom")]
    [InverseProperty("SaleOrderLines")]
    public virtual UomUom? ProductUomNavigation { get; set; }

    [ForeignKey("ProjectId")]
    [InverseProperty("SaleOrderLines")]
    public virtual ProjectProject? Project { get; set; }

    [InverseProperty("SaleLine")]
    [NotMapped]
    public virtual ICollection<ProjectMilestone> ProjectMilestones { get; } = new List<ProjectMilestone>();

    [InverseProperty("SaleLine")]
    [NotMapped]
    public virtual ICollection<ProjectProject> ProjectProjects { get; } = new List<ProjectProject>();

    [InverseProperty("SaleLine")]
    [NotMapped]
    public virtual ICollection<ProjectTask> ProjectTasks { get; } = new List<ProjectTask>();

    [InverseProperty("SaleLine")]
    [NotMapped]
    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    [ForeignKey("RouteId")]
    [InverseProperty("SaleOrderLines")]
    public virtual StockRoute? Route { get; set; }

    [InverseProperty("Line")]
    [NotMapped]
    public virtual ICollection<SaleOrderOption> SaleOrderOptions { get; } = new List<SaleOrderOption>();

    [ForeignKey("SalesmanId")]
    [InverseProperty("SaleOrderLineSalesmen")]
    public virtual ResUser? Salesman { get; set; }

    [InverseProperty("SaleLine")]
    [NotMapped]
    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    [ForeignKey("TaskId")]
    [InverseProperty("SaleOrderLines")]
    public virtual ProjectTask? Task { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("SaleOrderLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("SaleOrderLineId")]
    [InverseProperty("SaleOrderLines")]
    [NotMapped]
    public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();

    [ForeignKey("OrderLineId")]
    [InverseProperty("OrderLines")]
    [NotMapped]
    public virtual ICollection<AccountMoveLine> InvoiceLines { get; } = new List<AccountMoveLine>();

    [ForeignKey("SaleOrderLineId")]
    [InverseProperty("SaleOrderLines")]
    [NotMapped]
    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; } = new List<ProductTemplateAttributeValue>();
}