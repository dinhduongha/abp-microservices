using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("payment_refund_wizard")]
public partial class PaymentRefundWizard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("payment_id")]
    public Guid? PaymentId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("amount_to_refund")]
    public decimal? AmountToRefund { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("PaymentRefundWizardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PaymentId")]
    [InverseProperty("PaymentRefundWizards")]
    public virtual AccountPayment? Payment { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("PaymentRefundWizardWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
