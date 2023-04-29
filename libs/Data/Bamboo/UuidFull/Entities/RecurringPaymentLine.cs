using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("recurring_payment_line")]
public partial class RecurringPaymentLine
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
    public Guid? CompanyId { get; set; }

    [Column("payment_id")]
    public Guid? PaymentId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("amount")]
    public decimal? Amount { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("RecurringPaymentLines")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
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

    [ForeignKey("WriteUid")]
    [InverseProperty("RecurringPaymentLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
