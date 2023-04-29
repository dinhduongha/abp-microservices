using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_payment_term_line")]
[Index("PaymentId", Name = "account_payment_term_line_payment_id_index")]
public partial class AccountPaymentTermLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("months")]
    public long? Months { get; set; }

    [Column("days")]
    public long? Days { get; set; }

    [Column("days_after")]
    public long? DaysAfter { get; set; }

    [Column("discount_days")]
    public long? DiscountDays { get; set; }

    [Column("payment_id")]
    public Guid? PaymentId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("value")]
    public string? Value { get; set; }

    [Column("value_amount")]
    public decimal? ValueAmount { get; set; }

    [Column("end_month")]
    public bool? EndMonth { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("discount_percentage")]
    public double? DiscountPercentage { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountPaymentTermLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PaymentId")]
    [InverseProperty("AccountPaymentTermLines")]
    public virtual AccountPaymentTerm? Payment { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountPaymentTermLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
