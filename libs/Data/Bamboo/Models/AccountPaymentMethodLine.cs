using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountPaymentMethodLine
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? PaymentMethodId { get; set; }

    public Guid? PaymentAccountId { get; set; }

    public Guid? JournalId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? PaymentProviderId { get; set; }

    //public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; } = new List<AccountPaymentRegister>();

    //public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual AccountAccount? PaymentAccount { get; set; }

    public virtual AccountPaymentMethod? PaymentMethod { get; set; }

    public virtual PaymentProvider? PaymentProvider { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
