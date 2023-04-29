using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class SaleOrderLine
{
    public Guid Id { get; set; }

    public Guid? OrderId { get; set; }

    public long Sequence { get; set; }

    public Guid? CompanyId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? OrderPartnerId { get; set; }

    public Guid? SalesmanId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? ProductUom { get; set; }

    public Guid? ProductPackagingId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? State { get; set; }

    public string? DisplayType { get; set; }

    public string? QtyDeliveredMethod { get; set; }

    public string? InvoiceStatus { get; set; }

    public string? AnalyticDistribution { get; set; }

    public string? Name { get; set; }

    public decimal? ProductUomQty { get; set; }

    public decimal? PriceUnit { get; set; }

    public decimal? Discount { get; set; }

    public decimal? PriceReduce { get; set; }

    public decimal? PriceSubtotal { get; set; }

    public decimal? PriceTotal { get; set; }

    public decimal? PriceReduceTaxexcl { get; set; }

    public decimal? PriceReduceTaxinc { get; set; }

    public decimal? QtyDelivered { get; set; }

    public decimal? QtyInvoiced { get; set; }

    public decimal? QtyToInvoice { get; set; }

    public decimal? UntaxedAmountInvoiced { get; set; }

    public decimal? UntaxedAmountToInvoice { get; set; }

    public bool? IsDownpayment { get; set; }

    public bool? IsExpense { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? PriceTax { get; set; }

    public double? ProductPackagingQty { get; set; }

    public double? CustomerLead { get; set; }

    public Guid? RouteId { get; set; }

    public bool? IsService { get; set; }

    public Guid? ProjectId { get; set; }

    public Guid? TaskId { get; set; }

    public Guid? LinkedLineId { get; set; }

    public string? ShopWarning { get; set; }

    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<SaleOrderLine> InverseLinkedLine { get; } = new List<SaleOrderLine>();

    public virtual SaleOrderLine? LinkedLine { get; set; }

    public virtual SaleOrder? Order { get; set; }

    public virtual ResPartner? OrderPartner { get; set; }

    public virtual ICollection<PosOrderLine> PosOrderLines { get; } = new List<PosOrderLine>();

    public virtual ProductProduct? Product { get; set; }

    public virtual ICollection<ProductAttributeCustomValue> ProductAttributeCustomValues { get; } = new List<ProductAttributeCustomValue>();

    public virtual ProductPackaging? ProductPackaging { get; set; }

    public virtual UomUom? ProductUomNavigation { get; set; }

    public virtual ProjectProject? Project { get; set; }

    public virtual ICollection<ProjectMilestone> ProjectMilestones { get; } = new List<ProjectMilestone>();

    public virtual ICollection<ProjectProject> ProjectProjects { get; } = new List<ProjectProject>();

    public virtual ICollection<ProjectTask> ProjectTasks { get; } = new List<ProjectTask>();

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    public virtual StockRoute? Route { get; set; }

    public virtual ICollection<SaleOrderOption> SaleOrderOptions { get; } = new List<SaleOrderOption>();

    public virtual ResUser? Salesman { get; set; }

    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    public virtual ProjectTask? Task { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();

    public virtual ICollection<AccountMoveLine> InvoiceLines { get; } = new List<AccountMoveLine>();

    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; } = new List<ProductTemplateAttributeValue>();
}
