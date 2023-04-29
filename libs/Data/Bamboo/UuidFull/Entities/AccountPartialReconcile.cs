using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_partial_reconcile")]
[Index("CreditMoveId", Name = "account_partial_reconcile_credit_move_id_index")]
[Index("DebitMoveId", Name = "account_partial_reconcile_debit_move_id_index")]
public partial class AccountPartialReconcile
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("debit_move_id")]
    public Guid? DebitMoveId { get; set; }

    [Column("credit_move_id")]
    public Guid? CreditMoveId { get; set; }

    [Column("full_reconcile_id")]
    public Guid? FullReconcileId { get; set; }

    [Column("exchange_move_id")]
    public Guid? ExchangeMoveId { get; set; }

    [Column("debit_currency_id")]
    public long? DebitCurrencyId { get; set; }

    [Column("credit_currency_id")]
    public long? CreditCurrencyId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("max_date")]
    public DateOnly? MaxDate { get; set; }

    [Column("amount")]
    public decimal? Amount { get; set; }

    [Column("debit_amount_currency")]
    public decimal? DebitAmountCurrency { get; set; }

    [Column("credit_amount_currency")]
    public decimal? CreditAmountCurrency { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [InverseProperty("TaxCashBasisRec")]
    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountPartialReconciles")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountPartialReconcileCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CreditMoveId")]
    [InverseProperty("AccountPartialReconcileCreditMoves")]
    public virtual AccountMoveLine? CreditMove { get; set; }

    [ForeignKey("DebitMoveId")]
    [InverseProperty("AccountPartialReconcileDebitMoves")]
    public virtual AccountMoveLine? DebitMove { get; set; }

    [ForeignKey("ExchangeMoveId")]
    [InverseProperty("AccountPartialReconciles")]
    public virtual AccountMove? ExchangeMove { get; set; }

    [ForeignKey("FullReconcileId")]
    [InverseProperty("AccountPartialReconciles")]
    public virtual AccountFullReconcile? FullReconcile { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountPartialReconcileWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
