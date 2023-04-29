using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class PaymentRefundWizard
{
    public Guid Id { get; set; }

    public Guid? PaymentId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public decimal? AmountToRefund { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountPayment? Payment { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
