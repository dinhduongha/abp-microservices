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

[Table("pos_payment")]
[Index("SessionId", Name = "pos_payment_session_id_index")]
public partial class PosPayment: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("pos_order_id")]
    public Guid? PosOrderId { get; set; }

    [Column("payment_method_id")]
    public long? PaymentMethodId { get; set; }

    [Column("session_id")]
    public Guid? SessionId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("account_move_id")]
    public Guid? AccountMoveId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("card_type")]
    public string? CardType { get; set; }

    [Column("cardholder_name")]
    public string? CardholderName { get; set; }

    [Column("transaction_id")]
    public string? TransactionId { get; set; }

    [Column("payment_status")]
    public string? PaymentStatus { get; set; }

    [Column("ticket")]
    public string? Ticket { get; set; }

    [Column("amount")]
    public decimal? Amount { get; set; }

    [Column("is_change")]
    public bool? IsChange { get; set; }

    [Column("payment_date", TypeName = "timestamp without time zone")]
    public DateTime? PaymentDate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("AccountMoveId")]
    //[InverseProperty("PosPayments")]
    public virtual AccountMove? AccountMove { get; set; }

    [ForeignKey("TenantId")]
    //[InverseProperty("PosPayments")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("PosPaymentCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PaymentMethodId")]
    //[InverseProperty("PosPayments")]
    public virtual PosPaymentMethod? PaymentMethod { get; set; }

    [ForeignKey("PosOrderId")]
    //[InverseProperty("PosPayments")]
    public virtual PosOrder? PosOrder { get; set; }

    [ForeignKey("SessionId")]
    //[InverseProperty("PosPayments")]
    public virtual PosSession? Session { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("PosPaymentWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
