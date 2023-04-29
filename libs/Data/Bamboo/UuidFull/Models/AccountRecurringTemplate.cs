using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountRecurringTemplate
{
    public Guid Id { get; set; }

    public Guid? JournalId { get; set; }

    public long? RecurringInterval { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? RecurringPeriod { get; set; }

    public string? State { get; set; }

    public string? JournalState { get; set; }

    public string? Description { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual ICollection<RecurringPayment> RecurringPayments { get; } = new List<RecurringPayment>();

    public virtual ResUser? WriteU { get; set; }
}
