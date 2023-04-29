using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("sale_order")]
[Index("CompanyId", Name = "sale_order_company_id_index")]
[Index("CreateDate", Name = "sale_order_create_date_index")]
[Index("DateOrder", "Id", Name = "sale_order_date_order_id_idx", AllDescending = true)]
[Index("PartnerId", Name = "sale_order_partner_id_index")]
[Index("State", Name = "sale_order_state_index")]
[Index("UserId", Name = "sale_order_user_id_index")]
public partial class SaleOrder
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("campaign_id")]
    public Guid? CampaignId { get; set; }

    [Column("source_id")]
    public Guid? SourceId { get; set; }

    [Column("medium_id")]
    public Guid? MediumId { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("partner_invoice_id")]
    public Guid? PartnerInvoiceId { get; set; }

    [Column("partner_shipping_id")]
    public Guid? PartnerShippingId { get; set; }

    [Column("fiscal_position_id")]
    public Guid? FiscalPositionId { get; set; }

    [Column("payment_term_id")]
    public Guid? PaymentTermId { get; set; }

    [Column("pricelist_id")]
    public Guid? PricelistId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("team_id")]
    public Guid? TeamId { get; set; }

    [Column("analytic_account_id")]
    public Guid? AnalyticAccountId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("access_token")]
    public string? AccessToken { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("client_order_ref")]
    public string? ClientOrderRef { get; set; }

    [Column("origin")]
    public string? Origin { get; set; }

    [Column("reference")]
    public string? Reference { get; set; }

    [Column("signed_by")]
    public string? SignedBy { get; set; }

    [Column("invoice_status")]
    public string? InvoiceStatus { get; set; }

    [Column("validity_date")]
    public DateOnly? ValidityDate { get; set; }

    [Column("note")]
    public string? Note { get; set; }

    [Column("currency_rate")]
    public decimal? CurrencyRate { get; set; }

    [Column("amount_untaxed")]
    public decimal? AmountUntaxed { get; set; }

    [Column("amount_tax")]
    public decimal? AmountTax { get; set; }

    [Column("amount_total")]
    public decimal? AmountTotal { get; set; }

    [Column("require_signature")]
    public bool? RequireSignature { get; set; }

    [Column("require_payment")]
    public bool? RequirePayment { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("commitment_date", TypeName = "timestamp without time zone")]
    public DateTime? CommitmentDate { get; set; }

    [Column("date_order", TypeName = "timestamp without time zone")]
    public DateTime? DateOrder { get; set; }

    [Column("signed_on", TypeName = "timestamp without time zone")]
    public DateTime? SignedOn { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("sale_order_template_id")]
    public Guid? SaleOrderTemplateId { get; set; }

    [Column("incoterm")]
    public Guid? Incoterm { get; set; }

    [Column("warehouse_id")]
    public Guid? WarehouseId { get; set; }

    [Column("procurement_group_id")]
    public Guid? ProcurementGroupId { get; set; }

    [Column("incoterm_location")]
    public string? IncotermLocation { get; set; }

    [Column("picking_policy")]
    public string? PickingPolicy { get; set; }

    [Column("delivery_status")]
    public string? DeliveryStatus { get; set; }

    [Column("effective_date", TypeName = "timestamp without time zone")]
    public DateTime? EffectiveDate { get; set; }

    [Column("amount_unpaid")]
    public decimal? AmountUnpaid { get; set; }

    [Column("opportunity_id")]
    public Guid? OpportunityId { get; set; }

    [Column("project_id")]
    public Guid? ProjectId { get; set; }

    [Column("website_id")]
    public Guid? WebsiteId { get; set; }

    [Column("shop_warning")]
    public string? ShopWarning { get; set; }

    [Column("cart_recovery_email_sent")]
    public bool? CartRecoveryEmailSent { get; set; }

    [ForeignKey("AnalyticAccountId")]
    [InverseProperty("SaleOrders")]
    public virtual AccountAnalyticAccount? AnalyticAccount { get; set; }

    [ForeignKey("CampaignId")]
    [InverseProperty("SaleOrders")]
    public virtual UtmCampaign? Campaign { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("SaleOrders")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("SaleOrderCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("FiscalPositionId")]
    [InverseProperty("SaleOrders")]
    public virtual AccountFiscalPosition? FiscalPosition { get; set; }

    [InverseProperty("SaleOrder")]
    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; } = new List<HrExpenseSplit>();

    [InverseProperty("SaleOrder")]
    public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();

    [ForeignKey("Incoterm")]
    [InverseProperty("SaleOrders")]
    public virtual AccountIncoterm? IncotermNavigation { get; set; }

    [ForeignKey("MediumId")]
    [InverseProperty("SaleOrders")]
    public virtual UtmMedium? Medium { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("SaleOrders")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("OpportunityId")]
    [InverseProperty("SaleOrders")]
    public virtual CrmLead? Opportunity { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("SaleOrderPartners")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("PartnerInvoiceId")]
    [InverseProperty("SaleOrderPartnerInvoices")]
    public virtual ResPartner? PartnerInvoice { get; set; }

    [ForeignKey("PartnerShippingId")]
    [InverseProperty("SaleOrderPartnerShippings")]
    public virtual ResPartner? PartnerShipping { get; set; }

    [ForeignKey("PaymentTermId")]
    [InverseProperty("SaleOrders")]
    public virtual AccountPaymentTerm? PaymentTerm { get; set; }

    [InverseProperty("SaleOrderOrigin")]
    public virtual ICollection<PosOrderLine> PosOrderLines { get; } = new List<PosOrderLine>();

    [ForeignKey("PricelistId")]
    [InverseProperty("SaleOrders")]
    public virtual ProductPricelist? Pricelist { get; set; }

    [ForeignKey("ProcurementGroupId")]
    [InverseProperty("SaleOrders")]
    public virtual ProcurementGroup? ProcurementGroup { get; set; }

    [InverseProperty("Sale")]
    public virtual ICollection<ProcurementGroup> ProcurementGroups { get; } = new List<ProcurementGroup>();

    [ForeignKey("ProjectId")]
    [InverseProperty("SaleOrders")]
    public virtual ProjectProject? Project { get; set; }

    [InverseProperty("SaleOrder")]
    public virtual ICollection<ProjectTask> ProjectTasks { get; } = new List<ProjectTask>();

    [InverseProperty("SaleOrder")]
    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    [InverseProperty("SaleOrder")]
    public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    [InverseProperty("Order")]
    public virtual ICollection<SaleOrderCancel> SaleOrderCancels { get; } = new List<SaleOrderCancel>();

    [InverseProperty("Order")]
    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();

    [InverseProperty("Order")]
    public virtual ICollection<SaleOrderOption> SaleOrderOptions { get; } = new List<SaleOrderOption>();

    [InverseProperty("Order")]
    public virtual ICollection<SaleOrderTagRel> SaleOrderTagRels { get; } = new List<SaleOrderTagRel>();

    [ForeignKey("SaleOrderTemplateId")]
    [InverseProperty("SaleOrders")]
    public virtual SaleOrderTemplate? SaleOrderTemplate { get; set; }

    [ForeignKey("SourceId")]
    [InverseProperty("SaleOrders")]
    public virtual UtmSource? Source { get; set; }

    [InverseProperty("Sale")]
    public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();

    [ForeignKey("TeamId")]
    [InverseProperty("SaleOrders")]
    public virtual CrmTeam? Team { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("SaleOrderUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WarehouseId")]
    [InverseProperty("SaleOrders")]
    public virtual StockWarehouse? Warehouse { get; set; }

    [ForeignKey("WebsiteId")]
    [InverseProperty("SaleOrders")]
    public virtual Website? Website { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("SaleOrderWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("SaleOrderId")]
    [InverseProperty("SaleOrders")]
    public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvs { get; } = new List<SaleAdvancePaymentInv>();

    [ForeignKey("SaleOrderId")]
    [InverseProperty("SaleOrders")]
    public virtual ICollection<PaymentTransaction> Transactions { get; } = new List<PaymentTransaction>();
}
