using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

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
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("payment_name")]
    public string? PaymentName { get; set; }

    [Column("amount")]
    public decimal? Amount { get; set; }

    [Column("payment_date", TypeName = "timestamp without time zone")]
    public DateTime? PaymentDate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("ConfigId")]
    [InverseProperty("PosMakePayments")]
    public virtual PosConfig? Config { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("PosMakePaymentCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("PosMakePaymentWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
