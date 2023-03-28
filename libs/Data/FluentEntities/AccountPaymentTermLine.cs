using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountPaymentTermLine
{
    public Guid Id { get; set; }

    public long? Months { get; set; }

    public long? Days { get; set; }

    public long? DaysAfter { get; set; }

    public long? DiscountDays { get; set; }

    public Guid? PaymentId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Value { get; set; }

    public decimal? ValueAmount { get; set; }

    public bool? EndMonth { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? DiscountPercentage { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountPaymentTerm? Payment { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
