using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_reconcile_model_line")]
public partial class AccountReconcileModelLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("model_id")]
    public Guid? ModelId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("account_id")]
    public Guid? AccountId { get; set; }

    [Column("journal_id")]
    public Guid? JournalId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("label")]
    public string? Label { get; set; }

    [Column("amount_type")]
    public string? AmountType { get; set; }

    [Column("amount_string")]
    public string? AmountString { get; set; }

    [Column("analytic_distribution", TypeName = "jsonb")]
    public string? AnalyticDistribution { get; set; }

    [Column("force_tax_included")]
    public bool? ForceTaxIncluded { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("amount")]
    public double? Amount { get; set; }

    [ForeignKey("AccountId")]
    [InverseProperty("AccountReconcileModelLines")]
    public virtual AccountAccount? Account { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountReconcileModelLines")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountReconcileModelLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("JournalId")]
    [InverseProperty("AccountReconcileModelLines")]
    public virtual AccountJournal? Journal { get; set; }

    [ForeignKey("ModelId")]
    [InverseProperty("AccountReconcileModelLines")]
    public virtual AccountReconcileModel? Model { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountReconcileModelLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountReconcileModelLineId")]
    [InverseProperty("AccountReconcileModelLines")]
    public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();
}
