using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountFinancialReport
{
    public Guid Id { get; set; }

    public Guid? ParentId { get; set; }

    public long? Sequence { get; set; }

    public long? Level { get; set; }

    public Guid? AccountReportId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Type { get; set; }

    public string? ReportDomain { get; set; }

    public string? Sign { get; set; }

    public string? DisplayDetail { get; set; }

    public string? StyleOverwrite { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual AccountFinancialReport? AccountReport { get; set; }

    //public virtual ICollection<AccountingReport> AccountingReports { get; } = new List<AccountingReport>();

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<AccountFinancialReport> InverseAccountReport { get; } = new List<AccountFinancialReport>();

    //public virtual ICollection<AccountFinancialReport> InverseParent { get; } = new List<AccountFinancialReport>();

    public virtual AccountFinancialReport? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountAccountType> AccountTypes { get; } = new List<AccountAccountType>();

    //public virtual ICollection<AccountAccount> Accounts { get; } = new List<AccountAccount>();
}
