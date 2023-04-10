using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class PaymentToken
{
    public Guid Id { get; set; }

    public Guid? ProviderId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? PaymentDetails { get; set; }

    public string? ProviderRef { get; set; }

    public bool? Verified { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; } = new List<AccountPaymentRegister>();

    //public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Partner { get; set; }

    //public virtual ICollection<PaymentTransaction> PaymentTransactions { get; } = new List<PaymentTransaction>();

    public virtual PaymentProvider? Provider { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
