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

[Table("account_bank_statement_line")]
[Index("InternalIndex", Name = "account_bank_statement_line_internal_index_index")]
[Index("UniqueImportId", Name = "account_bank_statement_line_unique_import_id", IsUnique = true)]
public partial class AccountBankStatementLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("move_id")]
    public Guid? MoveId { get; set; }

    [Column("statement_id")]
    public Guid? StatementId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("foreign_currency_id")]
    public long? ForeignCurrencyId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("account_number")]
    public string? AccountNumber { get; set; }

    [Column("partner_name")]
    public string? PartnerName { get; set; }

    [Column("transaction_type")]
    public string? TransactionType { get; set; }

    [Column("payment_ref")]
    public string? PaymentRef { get; set; }

    [Column("internal_index")]
    public string? InternalIndex { get; set; }

    [Column("amount")]
    public decimal? Amount { get; set; }

    [Column("amount_currency")]
    public decimal? AmountCurrency { get; set; }

    [Column("is_reconciled")]
    public bool? IsReconciled { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("amount_residual")]
    public double? AmountResidual { get; set; }

    [Column("pos_session_id")]
    public Guid? PosSessionId { get; set; }

    [Column("unique_import_id")]
    public string? UniqueImportId { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("AccountBankStatementLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CurrencyId")]
    [InverseProperty("AccountBankStatementLineCurrencies")]
    public virtual ResCurrency? Currency { get; set; }

    [ForeignKey("ForeignCurrencyId")]
    [InverseProperty("AccountBankStatementLineForeignCurrencies")]
    public virtual ResCurrency? ForeignCurrency { get; set; }

    [ForeignKey("MoveId")]
    [InverseProperty("AccountBankStatementLines")]
    public virtual AccountMove? Move { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("AccountBankStatementLines")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("PosSessionId")]
    [InverseProperty("AccountBankStatementLines")]
    public virtual PosSession? PosSession { get; set; }

    [ForeignKey("StatementId")]
    [InverseProperty("AccountBankStatementLines")]
    public virtual AccountBankStatement? Statement { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("AccountBankStatementLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("StatementLine")]
    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    [InverseProperty("StatementLine")]
    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();
    
    [ForeignKey("AccountBankStatementLineId")]
    [InverseProperty("AccountBankStatementLines")]
    public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();
}
