using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class PaymentRefundWizard
{
    public Guid Id { get; set; }

    public Guid? PaymentId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public decimal? AmountToRefund { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountPayment? Payment { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
