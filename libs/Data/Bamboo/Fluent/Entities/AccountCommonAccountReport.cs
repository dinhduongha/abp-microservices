using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountCommonAccountReport
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? TargetMove { get; set; }

    public string? DisplayAccount { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateOnly? DateTo { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountAccount> AccountAccounts { get; } = new List<AccountAccount>();

    //public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccounts { get; } = new List<AccountAnalyticAccount>();

    //public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    //public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();
}
