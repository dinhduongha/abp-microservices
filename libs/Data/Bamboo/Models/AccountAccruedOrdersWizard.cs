using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountAccruedOrdersWizard
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateOnly? Date { get; set; }

    public DateOnly? ReversalDate { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual AccountAccount? Account { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
