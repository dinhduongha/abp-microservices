using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class SaleOrder
{
    public Guid Id { get; set; }

    public Guid? CampaignId { get; set; }

    public Guid? SourceId { get; set; }

    public Guid? MediumId { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? PartnerInvoiceId { get; set; }

    public Guid? PartnerShippingId { get; set; }

    public Guid? FiscalPositionId { get; set; }

    public Guid? PaymentTermId { get; set; }

    public Guid? PricelistId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? TeamId { get; set; }

    public Guid? AnalyticAccountId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? AccessToken { get; set; }

    public string? Name { get; set; }

    public string? State { get; set; }

    public string? ClientOrderRef { get; set; }

    public string? Origin { get; set; }

    public string? Reference { get; set; }

    public string? SignedBy { get; set; }

    public string? InvoiceStatus { get; set; }

    public DateOnly? ValidityDate { get; set; }

    public string? Note { get; set; }

    public decimal? CurrencyRate { get; set; }

    public decimal? AmountUntaxed { get; set; }

    public decimal? AmountTax { get; set; }

    public decimal? AmountTotal { get; set; }

    public bool? RequireSignature { get; set; }

    public bool? RequirePayment { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? CommitmentDate { get; set; }

    public DateTime? DateOrder { get; set; }

    public DateTime? SignedOn { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? SaleOrderTemplateId { get; set; }

    public Guid? Incoterm { get; set; }

    public Guid? WarehouseId { get; set; }

    public Guid? ProcurementGroupId { get; set; }

    public string? IncotermLocation { get; set; }

    public string? PickingPolicy { get; set; }

    public string? DeliveryStatus { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public decimal? AmountUnpaid { get; set; }

    public Guid? OpportunityId { get; set; }

    public Guid? ProjectId { get; set; }

    public Guid? WebsiteId { get; set; }

    public string? ShopWarning { get; set; }

    public bool? CartRecoveryEmailSent { get; set; }

    public virtual AccountAnalyticAccount? AnalyticAccount { get; set; }

    public virtual UtmCampaign? Campaign { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountFiscalPosition? FiscalPosition { get; set; }

    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; } = new List<HrExpenseSplit>();

    public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();

    public virtual AccountIncoterm? IncotermNavigation { get; set; }

    public virtual UtmMedium? Medium { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual CrmLead? Opportunity { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResPartner? PartnerInvoice { get; set; }

    public virtual ResPartner? PartnerShipping { get; set; }

    public virtual AccountPaymentTerm? PaymentTerm { get; set; }

    public virtual ICollection<PosOrderLine> PosOrderLines { get; } = new List<PosOrderLine>();

    public virtual ProductPricelist? Pricelist { get; set; }

    public virtual ProcurementGroup? ProcurementGroup { get; set; }

    public virtual ICollection<ProcurementGroup> ProcurementGroups { get; } = new List<ProcurementGroup>();

    public virtual ProjectProject? Project { get; set; }

    public virtual ICollection<ProjectTask> ProjectTasks { get; } = new List<ProjectTask>();

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    public virtual ICollection<SaleOrderCancel> SaleOrderCancels { get; } = new List<SaleOrderCancel>();

    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();

    public virtual ICollection<SaleOrderOption> SaleOrderOptions { get; } = new List<SaleOrderOption>();

    public virtual ICollection<SaleOrderTagRel> SaleOrderTagRels { get; } = new List<SaleOrderTagRel>();

    public virtual SaleOrderTemplate? SaleOrderTemplate { get; set; }

    public virtual UtmSource? Source { get; set; }

    public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();

    public virtual CrmTeam? Team { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual StockWarehouse? Warehouse { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvs { get; } = new List<SaleAdvancePaymentInv>();

    public virtual ICollection<PaymentTransaction> Transactions { get; } = new List<PaymentTransaction>();
}
