using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountFinancialReport
{
    public Guid Id { get; set; }

    public Guid? ParentId { get; set; }

    public long? Sequence { get; set; }

    public long? Level { get; set; }

    public Guid? AccountReportId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Type { get; set; }

    public string? ReportDomain { get; set; }

    public string? Sign { get; set; }

    public string? DisplayDetail { get; set; }

    public string? StyleOverwrite { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountAccountFinancialReportType> AccountAccountFinancialReportTypes { get; } = new List<AccountAccountFinancialReportType>();

    public virtual AccountFinancialReport? AccountReport { get; set; }

    public virtual ICollection<AccountingReport> AccountingReports { get; } = new List<AccountingReport>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<AccountFinancialReport> InverseAccountReport { get; } = new List<AccountFinancialReport>();

    public virtual ICollection<AccountFinancialReport> InverseParent { get; } = new List<AccountFinancialReport>();

    public virtual AccountFinancialReport? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountAccount> Accounts { get; } = new List<AccountAccount>();
}
