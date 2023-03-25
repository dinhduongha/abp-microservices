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

[Table("account_reconcile_model_line")]
public partial class AccountReconcileModelLine: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("model_id")]
    public Guid? ModelId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("account_id")]
    public Guid? AccountId { get; set; }

    [Column("journal_id")]
    public Guid? JournalId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

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
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("amount")]
    public double? Amount { get; set; }

    [ForeignKey("AccountId")]
    [InverseProperty("AccountReconcileModelLines")]
    public virtual AccountAccount? Account { get; set; }

    [ForeignKey("TenantId")]
    [InverseProperty("AccountReconcileModelLines")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("AccountReconcileModelLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("JournalId")]
    [InverseProperty("AccountReconcileModelLines")]
    public virtual AccountJournal? Journal { get; set; }

    [ForeignKey("ModelId")]
    [InverseProperty("AccountReconcileModelLines")]
    public virtual AccountReconcileModel? Model { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("AccountReconcileModelLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountReconcileModelLineId")]
    [InverseProperty("AccountReconcileModelLines")]
    public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();
}
