using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class PaymentProviderOnboardingWizard
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? PaymentMethod { get; set; }

    public string? PaypalUserType { get; set; }

    public string? PaypalEmailAccount { get; set; }

    public string? PaypalSellerAccount { get; set; }

    public string? PaypalPdtToken { get; set; }

    public string? ManualName { get; set; }

    public string? JournalName { get; set; }

    public string? AccNumber { get; set; }

    public string? ManualPostMsg { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
