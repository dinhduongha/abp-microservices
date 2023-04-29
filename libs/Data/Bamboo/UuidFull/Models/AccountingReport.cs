using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountingReport
{
    public Guid Id { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public Guid? AccountReportId { get; set; }

    public string? TargetMove { get; set; }

    public string? LabelFilter { get; set; }

    public string? FilterCmp { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateOnly? DateTo { get; set; }

    public DateOnly? DateFromCmp { get; set; }

    public DateOnly? DateToCmp { get; set; }

    public bool? EnableFilter { get; set; }

    public bool? DebitCredit { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual AccountFinancialReport? AccountReport { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();
}
