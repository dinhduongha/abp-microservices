using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("pos_payment_method")]
public partial class PosPaymentMethod
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("outstanding_account_id")]
    public Guid? OutstandingAccountId { get; set; }

    [Column("receivable_account_id")]
    public Guid? ReceivableAccountId { get; set; }

    [Column("journal_id")]
    public Guid? JournalId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("use_payment_terminal")]
    public string? UsePaymentTerminal { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("is_cash_count")]
    public bool? IsCashCount { get; set; }

    [Column("split_transactions")]
    public bool? SplitTransactions { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("PosPaymentMethods")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("PosPaymentMethodCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("JournalId")]
    [InverseProperty("PosPaymentMethods")]
    public virtual AccountJournal? Journal { get; set; }

    [ForeignKey("OutstandingAccountId")]
    [InverseProperty("PosPaymentMethodOutstandingAccounts")]
    public virtual AccountAccount? OutstandingAccount { get; set; }

    [ForeignKey("ReceivableAccountId")]
    [InverseProperty("PosPaymentMethodReceivableAccounts")]
    public virtual AccountAccount? ReceivableAccount { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("PosPaymentMethodWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
