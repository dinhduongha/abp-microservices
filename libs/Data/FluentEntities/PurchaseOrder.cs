using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class PurchaseOrder
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? DestAddressId { get; set; }

    public long? CurrencyId { get; set; }

    public long? InvoiceCount { get; set; }

    public Guid? FiscalPositionId { get; set; }

    public Guid? PaymentTermId { get; set; }

    public Guid? IncotermId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? AccessToken { get; set; }

    public string? Name { get; set; }

    public string? Priority { get; set; }

    public string? Origin { get; set; }

    public string? PartnerRef { get; set; }

    public string? State { get; set; }

    public string? InvoiceStatus { get; set; }

    public string? Notes { get; set; }

    public decimal? AmountUntaxed { get; set; }

    public decimal? AmountTax { get; set; }

    public decimal? AmountTotal { get; set; }

    public bool? MailReminderConfirmed { get; set; }

    public bool? MailReceptionConfirmed { get; set; }

    public DateTime? DateOrder { get; set; }

    public DateTime? DateApprove { get; set; }

    public DateTime? DatePlanned { get; set; }

    public DateTime? DateCalendarStart { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? CurrencyRate { get; set; }

    public Guid? PickingTypeId { get; set; }

    public Guid? GroupId { get; set; }

    public string? IncotermLocation { get; set; }

    public string? ReceiptStatus { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual ResPartner? DestAddress { get; set; }

    public virtual AccountFiscalPosition? FiscalPosition { get; set; }

    public virtual ProcurementGroup? Group { get; set; }

    public virtual AccountIncoterm? Incoterm { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual AccountPaymentTerm? PaymentTerm { get; set; }

    public virtual StockPickingType? PickingType { get; set; }

    //public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    //public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();
}
