using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountPaymentMethodLine
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? PaymentMethodId { get; set; }

    public Guid? PaymentAccountId { get; set; }

    public Guid? JournalId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? PaymentProviderId { get; set; }

    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; } = new List<AccountPaymentRegister>();

    public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual AccountAccount? PaymentAccount { get; set; }

    public virtual AccountPaymentMethod? PaymentMethod { get; set; }

    public virtual PaymentProvider? PaymentProvider { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
