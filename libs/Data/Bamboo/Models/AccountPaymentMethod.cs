using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountPaymentMethod
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Code { get; set; }

    public string? PaymentType { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountPaymentMethodLine> AccountPaymentMethodLines { get; } = new List<AccountPaymentMethodLine>();

    //public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
