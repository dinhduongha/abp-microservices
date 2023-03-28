using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountPayment
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? MoveId { get; set; }

    public Guid? PartnerBankId { get; set; }

    public Guid? PairedInternalTransferPaymentId { get; set; }

    public Guid? PaymentMethodLineId { get; set; }

    public Guid? PaymentMethodId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? OutstandingAccountId { get; set; }

    public Guid? DestinationAccountId { get; set; }

    public Guid? DestinationJournalId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? PaymentType { get; set; }

    public string? PartnerType { get; set; }

    public string? PaymentReference { get; set; }

    public decimal? Amount { get; set; }

    public decimal? AmountCompanyCurrencySigned { get; set; }

    public bool? IsReconciled { get; set; }

    public bool? IsMatched { get; set; }

    public bool? IsInternalTransfer { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? PaymentTransactionId { get; set; }

    public Guid? PaymentTokenId { get; set; }

    public Guid? SourcePaymentId { get; set; }

    public long? PosPaymentMethodId { get; set; }

    public Guid? ForceOutstandingAccountId { get; set; }

    public Guid? PosSessionId { get; set; }

    //public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    //public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual AccountAccount? DestinationAccount { get; set; }

    public virtual AccountJournal? DestinationJournal { get; set; }

    public virtual AccountAccount? ForceOutstandingAccount { get; set; }

    //public virtual ICollection<AccountPayment> InversePairedInternalTransferPayment { get; } = new List<AccountPayment>();

    //public virtual ICollection<AccountPayment> InverseSourcePayment { get; } = new List<AccountPayment>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual AccountMove? Move { get; set; }

    public virtual AccountAccount? OutstandingAccount { get; set; }

    public virtual AccountPayment? PairedInternalTransferPayment { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResPartnerBank? PartnerBank { get; set; }

    public virtual AccountPaymentMethod? PaymentMethod { get; set; }

    public virtual AccountPaymentMethodLine? PaymentMethodLine { get; set; }

    //public virtual ICollection<PaymentRefundWizard> PaymentRefundWizards { get; } = new List<PaymentRefundWizard>();

    public virtual PaymentToken? PaymentToken { get; set; }

    public virtual PaymentTransaction? PaymentTransaction { get; set; }

    //public virtual ICollection<PaymentTransaction> PaymentTransactions { get; } = new List<PaymentTransaction>();

    public virtual PosPaymentMethod? PosPaymentMethod { get; set; }

    public virtual PosSession? PosSession { get; set; }

    //public virtual ICollection<RecurringPaymentLine> RecurringPaymentLines { get; } = new List<RecurringPaymentLine>();

    public virtual AccountPayment? SourcePayment { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountBankStatementLine> AccountBankStatementLines { get; } = new List<AccountBankStatementLine>();
}
