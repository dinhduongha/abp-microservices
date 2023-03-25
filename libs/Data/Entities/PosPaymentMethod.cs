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

[Table("pos_payment_method")]
public partial class PosPaymentMethod: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("outstanding_account_id")]
    public Guid? OutstandingAccountId { get; set; }

    [Column("receivable_account_id")]
    public Guid? ReceivableAccountId { get; set; }

    [Column("journal_id")]
    public Guid? JournalId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

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
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [InverseProperty("PosPaymentMethod")]
    [NotMapped]
    public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    [ForeignKey("TenantId")]
    [InverseProperty("PosPaymentMethods")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("PosPaymentMethodCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("JournalId")]
    [InverseProperty("PosPaymentMethods")]
    public virtual AccountJournal? Journal { get; set; }

    [ForeignKey("OutstandingAccountId")]
    [InverseProperty("PosPaymentMethodOutstandingAccounts")]
    public virtual AccountAccount? OutstandingAccount { get; set; }

    [InverseProperty("PaymentMethod")]
    [NotMapped]
    public virtual ICollection<PosMakePayment> PosMakePayments { get; } = new List<PosMakePayment>();

    [InverseProperty("PaymentMethod")]
    [NotMapped]
    public virtual ICollection<PosPayment> PosPayments { get; } = new List<PosPayment>();

    [ForeignKey("ReceivableAccountId")]
    [InverseProperty("PosPaymentMethodReceivableAccounts")]
    public virtual AccountAccount? ReceivableAccount { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("PosPaymentMethodWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("PosPaymentMethodId")]
    [InverseProperty("PosPaymentMethods")]
    [NotMapped]
    public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();
}
