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

[Table("payment_refund_wizard")]
public partial class PaymentRefundWizard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("payment_id")]
    public Guid? PaymentId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("amount_to_refund")]
    public decimal? AmountToRefund { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("PaymentRefundWizardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PaymentId")]
    //[InverseProperty("PaymentRefundWizards")]
    public virtual AccountPayment? Payment { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("PaymentRefundWizardWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
