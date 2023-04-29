using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountAgedTrialBalance
{
    public Guid Id { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public long? PeriodLength { get; set; }

    public string? TargetMove { get; set; }

    public string? ResultSelection { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateOnly? DateTo { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();
}
