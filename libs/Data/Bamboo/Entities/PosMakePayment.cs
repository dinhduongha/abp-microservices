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

[Table("pos_make_payment")]
public partial class PosMakePayment
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("config_id")]
    public Guid? ConfigId { get; set; }

    [Column("payment_method_id")]
    public long? PaymentMethodId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("payment_name")]
    public string? PaymentName { get; set; }

    [Column("amount")]
    public decimal? Amount { get; set; }

    [Column("payment_date", TypeName = "timestamp without time zone")]
    public DateTime? PaymentDate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("ConfigId")]
    //[InverseProperty("PosMakePayments")]
    public virtual PosConfig? Config { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("PosMakePaymentCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PaymentMethodId")]
    //[InverseProperty("PosMakePayments")]
    public virtual PosPaymentMethod? PaymentMethod { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("PosMakePaymentWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
