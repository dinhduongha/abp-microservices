using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("account_move")]
[Index("TenantId", Name = "account_move_company_id_index")]
[Index("Date", Name = "account_move_date_index")]
[Index("InvoiceDateDue", Name = "account_move_invoice_date_due_index")]
[Index("InvoiceDate", Name = "account_move_invoice_date_index")]
[Index("MoveType", Name = "account_move_move_type_index")]
[Index("Name", Name = "account_move_name_index")]
[Index("JournalId", "State", "PaymentState", "MoveType", "Date", Name = "account_move_payment_idx")]
[Index("JournalId", "SequencePrefix", "SequenceNumber", "Name", Name = "account_move_sequence_index", IsDescending = new[] { false, true, true, false })]
[Index("JournalId", "Id", "SequencePrefix", Name = "account_move_sequence_index2", IsDescending = new[] { false, true, false })]
public partial class AccountMove: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence_number")]
    public long SequenceNumber { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("journal_id")]
    public Guid? JournalId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("payment_id")]
    public Guid? PaymentId { get; set; }

    [Column("statement_line_id")]
    public Guid? StatementLineId { get; set; }

    [Column("tax_cash_basis_rec_id")]
    public Guid? TaxCashBasisRecId { get; set; }

    [Column("tax_cash_basis_origin_move_id")]
    public Guid? TaxCashBasisOriginMoveId { get; set; }

    [Column("auto_post_origin_id")]
    public Guid? AutoPostOriginId { get; set; }

    [Column("secure_sequence_number")]
    public long? SecureSequenceNumber { get; set; }

    [Column("invoice_payment_term_id")]
    public Guid? InvoicePaymentTermId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("commercial_partner_id")]
    public Guid? CommercialPartnerId { get; set; }

    [Column("partner_shipping_id")]
    public Guid? PartnerShippingId { get; set; }

    [Column("partner_bank_id")]
    public Guid? PartnerBankId { get; set; }

    [Column("fiscal_position_id")]
    public Guid? FiscalPositionId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("reversed_entry_id")]
    public Guid? ReversedEntryId { get; set; }

    [Column("invoice_user_id")]
    public Guid? InvoiceUserId { get; set; }

    [Column("invoice_incoterm_id")]
    public Guid? InvoiceIncotermId { get; set; }

    [Column("invoice_cash_rounding_id")]
    public Guid? InvoiceCashRoundingId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("sequence_prefix")]
    public string? SequencePrefix { get; set; }

    [Column("access_token")]
    public string? AccessToken { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("ref")]
    public string? Ref { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("move_type")]
    public string? MoveType { get; set; }

    [Column("auto_post")]
    public string? AutoPost { get; set; }

    [Column("inalterable_hash")]
    public string? InalterableHash { get; set; }

    [Column("payment_reference")]
    public string? PaymentReference { get; set; }

    [Column("qr_code_method")]
    public string? QrCodeMethod { get; set; }

    [Column("payment_state")]
    public string? PaymentState { get; set; }

    [Column("invoice_source_email")]
    public string? InvoiceSourceEmail { get; set; }

    [Column("invoice_partner_display_name")]
    public string? InvoicePartnerDisplayName { get; set; }

    [Column("invoice_origin")]
    public string? InvoiceOrigin { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("auto_post_until")]
    public DateOnly? AutoPostUntil { get; set; }

    [Column("invoice_date")]
    public DateOnly? InvoiceDate { get; set; }

    [Column("invoice_date_due")]
    public DateOnly? InvoiceDateDue { get; set; }

    [Column("narration")]
    public string? Narration { get; set; }

    [Column("amount_untaxed")]
    public decimal? AmountUntaxed { get; set; }

    [Column("amount_tax")]
    public decimal? AmountTax { get; set; }

    [Column("amount_total")]
    public decimal? AmountTotal { get; set; }

    [Column("amount_residual")]
    public decimal? AmountResidual { get; set; }

    [Column("amount_untaxed_signed")]
    public decimal? AmountUntaxedSigned { get; set; }

    [Column("amount_tax_signed")]
    public decimal? AmountTaxSigned { get; set; }

    [Column("amount_total_signed")]
    public decimal? AmountTotalSigned { get; set; }

    [Column("amount_total_in_currency_signed")]
    public decimal? AmountTotalInCurrencySigned { get; set; }

    [Column("amount_residual_signed")]
    public decimal? AmountResidualSigned { get; set; }

    [Column("quick_edit_total_amount")]
    public decimal? QuickEditTotalAmount { get; set; }

    [Column("is_storno")]
    public bool? IsStorno { get; set; }

    [Column("always_tax_exigible")]
    public bool? AlwaysTaxExigible { get; set; }

    [Column("to_check")]
    public bool? ToCheck { get; set; }

    [Column("posted_before")]
    public bool? PostedBefore { get; set; }

    [Column("is_move_sent")]
    public bool? IsMoveSent { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("edi_state")]
    public string? EdiState { get; set; }

    [Column("campaign_id")]
    public Guid? CampaignId { get; set; }

    [Column("source_id")]
    public Guid? SourceId { get; set; }

    [Column("medium_id")]
    public Guid? MediumId { get; set; }

    [Column("team_id")]
    public Guid? TeamId { get; set; }

    [Column("stock_move_id")]
    public Guid? StockMoveId { get; set; }

    [Column("website_id")]
    public Guid? WebsiteId { get; set; }

    [ForeignKey("AutoPostOriginId")]
    [InverseProperty("InverseAutoPostOrigin")]
    public virtual AccountMove? AutoPostOrigin { get; set; }

    [ForeignKey("CampaignId")]
    [InverseProperty("AccountMoves")]
    public virtual UtmCampaign? Campaign { get; set; }

    [ForeignKey("CommercialPartnerId")]
    [InverseProperty("AccountMoveCommercialPartners")]
    public virtual ResPartner? CommercialPartner { get; set; }

    [ForeignKey("TenantId")]
    [InverseProperty("AccountMoves")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("AccountMoveCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CurrencyId")]
    [InverseProperty("AccountMoves")]
    public virtual ResCurrency? Currency { get; set; }

    [ForeignKey("FiscalPositionId")]
    [InverseProperty("AccountMoves")]
    public virtual AccountFiscalPosition? FiscalPosition { get; set; }

    [ForeignKey("InvoiceCashRoundingId")]
    [InverseProperty("AccountMoves")]
    public virtual AccountCashRounding? InvoiceCashRounding { get; set; }

    [ForeignKey("InvoiceIncotermId")]
    [InverseProperty("AccountMoves")]
    public virtual AccountIncoterm? InvoiceIncoterm { get; set; }

    [ForeignKey("InvoicePaymentTermId")]
    [InverseProperty("AccountMoves")]
    public virtual AccountPaymentTerm? InvoicePaymentTerm { get; set; }

    [ForeignKey("InvoiceUserId")]
    [InverseProperty("AccountMoveInvoiceUsers")]
    public virtual ResUser? InvoiceUser { get; set; }

    [ForeignKey("JournalId")]
    [InverseProperty("AccountMoves")]
    public virtual AccountJournal? Journal { get; set; }

    [ForeignKey("MediumId")]
    [InverseProperty("AccountMoves")]
    public virtual UtmMedium? Medium { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("AccountMoves")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("AccountMovePartners")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("PartnerBankId")]
    [InverseProperty("AccountMoves")]
    public virtual ResPartnerBank? PartnerBank { get; set; }

    [ForeignKey("PartnerShippingId")]
    [InverseProperty("AccountMovePartnerShippings")]
    public virtual ResPartner? PartnerShipping { get; set; }

    [ForeignKey("PaymentId")]
    [InverseProperty("AccountMoves")]
    public virtual AccountPayment? Payment { get; set; }

    [ForeignKey("ReversedEntryId")]
    [InverseProperty("InverseReversedEntry")]
    public virtual AccountMove? ReversedEntry { get; set; }

    [ForeignKey("SourceId")]
    [InverseProperty("AccountMoves")]
    public virtual UtmSource? Source { get; set; }

    [ForeignKey("StatementLineId")]
    [InverseProperty("AccountMoves")]
    public virtual AccountBankStatementLine? StatementLine { get; set; }

    [ForeignKey("StockMoveId")]
    [InverseProperty("AccountMoves")]
    public virtual StockMove? StockMove { get; set; }

    [ForeignKey("TaxCashBasisOriginMoveId")]
    [InverseProperty("InverseTaxCashBasisOriginMove")]
    public virtual AccountMove? TaxCashBasisOriginMove { get; set; }

    [ForeignKey("TaxCashBasisRecId")]
    [InverseProperty("AccountMoves")]
    public virtual AccountPartialReconcile? TaxCashBasisRec { get; set; }

    [ForeignKey("TeamId")]
    [InverseProperty("AccountMoves")]
    public virtual CrmTeam? Team { get; set; }

    [ForeignKey("WebsiteId")]
    [InverseProperty("AccountMoves")]
    public virtual Website? Website { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("AccountMoveWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("Invoice")]
    public virtual ICollection<AccountAssetAsset> AccountAssetAssets { get; } = new List<AccountAssetAsset>();

    [InverseProperty("Move")]
    public virtual ICollection<AccountAssetDepreciationLine> AccountAssetDepreciationLines { get; } = new List<AccountAssetDepreciationLine>();

    [InverseProperty("Move")]
    public virtual ICollection<AccountBankStatementLine> AccountBankStatementLines { get; } = new List<AccountBankStatementLine>();

    [InverseProperty("Move")]
    public virtual ICollection<AccountEdiDocument> AccountEdiDocuments { get; } = new List<AccountEdiDocument>();

    [InverseProperty("ExchangeMove")]
    public virtual ICollection<AccountFullReconcile> AccountFullReconciles { get; } = new List<AccountFullReconcile>();

    [InverseProperty("Move")]
    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    [InverseProperty("ExchangeMove")]
    public virtual ICollection<AccountPartialReconcile> AccountPartialReconciles { get; } = new List<AccountPartialReconcile>();

    [InverseProperty("Move")]
    public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    [InverseProperty("AccountMove")]
    public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; } = new List<HrExpenseSheet>();

    [InverseProperty("AutoPostOrigin")]
    public virtual ICollection<AccountMove> InverseAutoPostOrigin { get; } = new List<AccountMove>();

    [InverseProperty("ReversedEntry")]
    public virtual ICollection<AccountMove> InverseReversedEntry { get; } = new List<AccountMove>();

    [InverseProperty("TaxCashBasisOriginMove")]
    public virtual ICollection<AccountMove> InverseTaxCashBasisOriginMove { get; } = new List<AccountMove>();

    [InverseProperty("AccountMoveNavigation")]
    public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    [InverseProperty("AccountMove")]
    public virtual ICollection<PosPayment> PosPayments { get; } = new List<PosPayment>();

    [InverseProperty("Move")]
    public virtual ICollection<PosSession> PosSessions { get; } = new List<PosSession>();

    [InverseProperty("Invoice")]
    public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    [InverseProperty("AccountOpeningMove")]
    public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    [InverseProperty("AccountMove")]
    public virtual ICollection<StockValuationLayer> StockValuationLayers { get; } = new List<StockValuationLayer>();

    [ForeignKey("AccountMoveId")]
    [InverseProperty("AccountMoves")]
    public virtual ICollection<AccountInvoiceSend> AccountInvoiceSends { get; } = new List<AccountInvoiceSend>();

    [ForeignKey("AccountMoveId")]
    [InverseProperty("AccountMoves")]
    public virtual ICollection<AccountResequenceWizard> AccountResequenceWizards { get; } = new List<AccountResequenceWizard>();

    [ForeignKey("AccountMoveId")]
    [InverseProperty("AccountMoves")]
    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

    [ForeignKey("MoveId")]
    [InverseProperty("Moves")]
    public virtual ICollection<AccountMoveReversal> Reversals { get; } = new List<AccountMoveReversal>();

    [ForeignKey("NewMoveId")]
    [InverseProperty("NewMoves")]
    public virtual ICollection<AccountMoveReversal> ReversalsNavigation { get; } = new List<AccountMoveReversal>();

    [ForeignKey("InvoiceId")]
    [InverseProperty("Invoices")]
    public virtual ICollection<PaymentTransaction> Transactions { get; } = new List<PaymentTransaction>();
}
