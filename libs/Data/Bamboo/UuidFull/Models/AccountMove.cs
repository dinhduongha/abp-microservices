using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountMove
{
    public Guid Id { get; set; }

    public long SequenceNumber { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? JournalId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? PaymentId { get; set; }

    public Guid? StatementLineId { get; set; }

    public Guid? TaxCashBasisRecId { get; set; }

    public Guid? TaxCashBasisOriginMoveId { get; set; }

    public Guid? AutoPostOriginId { get; set; }

    public long? SecureSequenceNumber { get; set; }

    public Guid? InvoicePaymentTermId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? CommercialPartnerId { get; set; }

    public Guid? PartnerShippingId { get; set; }

    public Guid? PartnerBankId { get; set; }

    public Guid? FiscalPositionId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? ReversedEntryId { get; set; }

    public Guid? InvoiceUserId { get; set; }

    public Guid? InvoiceIncotermId { get; set; }

    public Guid? InvoiceCashRoundingId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? SequencePrefix { get; set; }

    public string? AccessToken { get; set; }

    public string? Name { get; set; }

    public string? Ref { get; set; }

    public string? State { get; set; }

    public string? MoveType { get; set; }

    public string? AutoPost { get; set; }

    public string? InalterableHash { get; set; }

    public string? PaymentReference { get; set; }

    public string? QrCodeMethod { get; set; }

    public string? PaymentState { get; set; }

    public string? InvoiceSourceEmail { get; set; }

    public string? InvoicePartnerDisplayName { get; set; }

    public string? InvoiceOrigin { get; set; }

    public DateOnly? Date { get; set; }

    public DateOnly? AutoPostUntil { get; set; }

    public DateOnly? InvoiceDate { get; set; }

    public DateOnly? InvoiceDateDue { get; set; }

    public string? Narration { get; set; }

    public decimal? AmountUntaxed { get; set; }

    public decimal? AmountTax { get; set; }

    public decimal? AmountTotal { get; set; }

    public decimal? AmountResidual { get; set; }

    public decimal? AmountUntaxedSigned { get; set; }

    public decimal? AmountTaxSigned { get; set; }

    public decimal? AmountTotalSigned { get; set; }

    public decimal? AmountTotalInCurrencySigned { get; set; }

    public decimal? AmountResidualSigned { get; set; }

    public decimal? QuickEditTotalAmount { get; set; }

    public bool? IsStorno { get; set; }

    public bool? AlwaysTaxExigible { get; set; }

    public bool? ToCheck { get; set; }

    public bool? PostedBefore { get; set; }

    public bool? IsMoveSent { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public string? EdiState { get; set; }

    public Guid? CampaignId { get; set; }

    public Guid? SourceId { get; set; }

    public Guid? MediumId { get; set; }

    public Guid? TeamId { get; set; }

    public Guid? StockMoveId { get; set; }

    public Guid? WebsiteId { get; set; }

    public virtual ICollection<AccountAssetAsset> AccountAssetAssets { get; } = new List<AccountAssetAsset>();

    public virtual ICollection<AccountAssetDepreciationLine> AccountAssetDepreciationLines { get; } = new List<AccountAssetDepreciationLine>();

    public virtual ICollection<AccountBankStatementLine> AccountBankStatementLines { get; } = new List<AccountBankStatementLine>();

    public virtual ICollection<AccountEdiDocument> AccountEdiDocuments { get; } = new List<AccountEdiDocument>();

    public virtual ICollection<AccountFullReconcile> AccountFullReconciles { get; } = new List<AccountFullReconcile>();

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountPartialReconcile> AccountPartialReconciles { get; } = new List<AccountPartialReconcile>();

    public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    public virtual AccountMove? AutoPostOrigin { get; set; }

    public virtual UtmCampaign? Campaign { get; set; }

    public virtual ResPartner? CommercialPartner { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountFiscalPosition? FiscalPosition { get; set; }

    public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; } = new List<HrExpenseSheet>();

    public virtual ICollection<AccountMove> InverseAutoPostOrigin { get; } = new List<AccountMove>();

    public virtual ICollection<AccountMove> InverseReversedEntry { get; } = new List<AccountMove>();

    public virtual ICollection<AccountMove> InverseTaxCashBasisOriginMove { get; } = new List<AccountMove>();

    public virtual AccountCashRounding? InvoiceCashRounding { get; set; }

    public virtual AccountIncoterm? InvoiceIncoterm { get; set; }

    public virtual AccountPaymentTerm? InvoicePaymentTerm { get; set; }

    public virtual ResUser? InvoiceUser { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual UtmMedium? Medium { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResPartnerBank? PartnerBank { get; set; }

    public virtual ResPartner? PartnerShipping { get; set; }

    public virtual AccountPayment? Payment { get; set; }

    public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    public virtual ICollection<PosPayment> PosPayments { get; } = new List<PosPayment>();

    public virtual ICollection<PosSession> PosSessions { get; } = new List<PosSession>();

    public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    public virtual AccountMove? ReversedEntry { get; set; }

    public virtual UtmSource? Source { get; set; }

    public virtual AccountBankStatementLine? StatementLine { get; set; }

    public virtual StockMove? StockMove { get; set; }

    public virtual ICollection<StockValuationLayer> StockValuationLayers { get; } = new List<StockValuationLayer>();

    public virtual AccountMove? TaxCashBasisOriginMove { get; set; }

    public virtual AccountPartialReconcile? TaxCashBasisRec { get; set; }

    public virtual CrmTeam? Team { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountInvoiceSend> AccountInvoiceSends { get; } = new List<AccountInvoiceSend>();

    public virtual ICollection<AccountResequenceWizard> AccountResequenceWizards { get; } = new List<AccountResequenceWizard>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

    public virtual ICollection<AccountMoveReversal> Reversals { get; } = new List<AccountMoveReversal>();

    public virtual ICollection<AccountMoveReversal> ReversalsNavigation { get; } = new List<AccountMoveReversal>();

    public virtual ICollection<PaymentTransaction> Transactions { get; } = new List<PaymentTransaction>();
}
