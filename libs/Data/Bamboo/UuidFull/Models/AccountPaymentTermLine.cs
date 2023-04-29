using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountPaymentTermLine
{
    public Guid Id { get; set; }

    public long? Months { get; set; }

    public long? Days { get; set; }

    public long? DaysAfter { get; set; }

    public long? DiscountDays { get; set; }

    public Guid? PaymentId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Value { get; set; }

    public decimal? ValueAmount { get; set; }

    public bool? EndMonth { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? DiscountPercentage { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountPaymentTerm? Payment { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
