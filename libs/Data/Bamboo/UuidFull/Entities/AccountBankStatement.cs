using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_bank_statement")]
[Index("FirstLineIndex", Name = "account_bank_statement_first_line_index_index")]
public partial class AccountBankStatement
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("journal_id")]
    public Guid? JournalId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("reference")]
    public string? Reference { get; set; }

    [Column("first_line_index")]
    public string? FirstLineIndex { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("balance_start")]
    public decimal? BalanceStart { get; set; }

    [Column("balance_end")]
    public decimal? BalanceEnd { get; set; }

    [Column("balance_end_real")]
    public decimal? BalanceEndReal { get; set; }

    [Column("is_complete")]
    public bool? IsComplete { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [InverseProperty("Statement")]
    public virtual ICollection<AccountBankStatementLine> AccountBankStatementLines { get; } = new List<AccountBankStatementLine>();

    [InverseProperty("Statement")]
    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountBankStatements")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountBankStatementCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("JournalId")]
    [InverseProperty("AccountBankStatements")]
    public virtual AccountJournal? Journal { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountBankStatementWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountBankStatementId")]
    [InverseProperty("AccountBankStatements")]
    public virtual ICollection<IrAttachment> IrAttachments { get; } = new List<IrAttachment>();
}
