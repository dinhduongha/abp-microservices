using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class PosPayment
{
    public Guid Id { get; set; }

    public Guid? PosOrderId { get; set; }

    public long? PaymentMethodId { get; set; }

    public Guid? SessionId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? AccountMoveId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? CardType { get; set; }

    public string? CardholderName { get; set; }

    public string? TransactionId { get; set; }

    public string? PaymentStatus { get; set; }

    public string? Ticket { get; set; }

    public decimal? Amount { get; set; }

    public bool? IsChange { get; set; }

    public DateTime? PaymentDate { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual AccountMove? AccountMove { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual PosPaymentMethod? PaymentMethod { get; set; }

    public virtual PosOrder? PosOrder { get; set; }

    public virtual PosSession? Session { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
