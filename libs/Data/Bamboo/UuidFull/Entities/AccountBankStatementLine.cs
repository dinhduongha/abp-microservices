using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

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
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

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
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("amount_residual")]
    public double? AmountResidual { get; set; }

    [Column("pos_session_id")]
    public Guid? PosSessionId { get; set; }

    [Column("unique_import_id")]
    public string? UniqueImportId { get; set; }

    [InverseProperty("StatementLine")]
    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    [InverseProperty("StatementLine")]
    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountBankStatementLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

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

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountBankStatementLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountBankStatementLineId")]
    [InverseProperty("AccountBankStatementLines")]
    public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();
}
