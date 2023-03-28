using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountBankStatementLine
{
    public Guid Id { get; set; }

    public Guid? MoveId { get; set; }

    public Guid? StatementId { get; set; }

    public long Sequence { get; set; }

    public Guid? PartnerId { get; set; }

    public long? CurrencyId { get; set; }

    public long? ForeignCurrencyId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? AccountNumber { get; set; }

    public string? PartnerName { get; set; }

    public string? TransactionType { get; set; }

    public string? PaymentRef { get; set; }

    public string? InternalIndex { get; set; }

    public decimal? Amount { get; set; }

    public decimal? AmountCurrency { get; set; }

    public bool? IsReconciled { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? AmountResidual { get; set; }

    public Guid? PosSessionId { get; set; }

    public string? UniqueImportId { get; set; }

    //public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    //public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual ResCurrency? ForeignCurrency { get; set; }

    public virtual AccountMove? Move { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual PosSession? PosSession { get; set; }

    public virtual AccountBankStatement? Statement { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();
}
