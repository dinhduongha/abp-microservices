using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class SalePaymentProviderOnboardingWizard
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? PaymentMethod { get; set; }

    public string? PaypalUserType { get; set; }

    public string? PaypalEmailAccount { get; set; }

    public string? PaypalSellerAccount { get; set; }

    public string? PaypalPdtToken { get; set; }

    public string? ManualName { get; set; }

    public string? JournalName { get; set; }

    public string? AccNumber { get; set; }

    public string? ManualPostMsg { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
