using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountAgedTrialBalance
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public long? PeriodLength { get; set; }

    public string? TargetMove { get; set; }

    public string? ResultSelection { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateOnly? DateTo { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    //public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();
}
