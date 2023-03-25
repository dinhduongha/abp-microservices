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

[Table("recurring_payment_line")]
public partial class RecurringPaymentLine: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("recurring_payment_id")]
    public Guid? RecurringPaymentId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("journal_id")]
    public Guid? JournalId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("payment_id")]
    public Guid? PaymentId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("amount")]
    public decimal? Amount { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("TenantId")]
    [InverseProperty("RecurringPaymentLines")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("RecurringPaymentLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("JournalId")]
    [InverseProperty("RecurringPaymentLines")]
    public virtual AccountJournal? Journal { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("RecurringPaymentLines")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("PaymentId")]
    [InverseProperty("RecurringPaymentLines")]
    public virtual AccountPayment? Payment { get; set; }

    [ForeignKey("RecurringPaymentId")]
    [InverseProperty("RecurringPaymentLines")]
    public virtual RecurringPayment? RecurringPayment { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("RecurringPaymentLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
