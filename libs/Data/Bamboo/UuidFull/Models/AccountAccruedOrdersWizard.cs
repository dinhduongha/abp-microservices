using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountAccruedOrdersWizard
{
    public Guid Id { get; set; }

    public Guid? CompanyId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateOnly? Date { get; set; }

    public DateOnly? ReversalDate { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual AccountAccount? Account { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
