using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class PosMakePayment
{
    public Guid Id { get; set; }

    public Guid? ConfigId { get; set; }

    public long? PaymentMethodId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? PaymentName { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? PaymentDate { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual PosConfig? Config { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual PosPaymentMethod? PaymentMethod { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
