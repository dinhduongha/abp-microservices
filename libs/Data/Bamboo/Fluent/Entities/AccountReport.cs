using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountReport
{
    public Guid Id { get; set; }

    public Guid? RootReportId { get; set; }

    public Guid? ChartTemplateId { get; set; }

    public long? CountryId { get; set; }

    public long? LoadMoreLimit { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? AvailabilityCondition { get; set; }

    public string? DefaultOpeningDateFilter { get; set; }

    public string? FilterMultiCompany { get; set; }

    public string? FilterHierarchy { get; set; }

    public string? Name { get; set; }

    public bool? OnlyTaxExigible { get; set; }

    public bool? SearchBar { get; set; }

    public bool? FilterDateRange { get; set; }

    public bool? FilterShowDraft { get; set; }

    public bool? FilterUnreconciled { get; set; }

    public bool? FilterUnfoldAll { get; set; }

    public bool? FilterPeriodComparison { get; set; }

    public bool? FilterGrowthComparison { get; set; }

    public bool? FilterJournals { get; set; }

    public bool? FilterAnalytic { get; set; }

    public bool? FilterAccountType { get; set; }

    public bool? FilterPartner { get; set; }

    public bool? FilterFiscalPosition { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountReportColumn> AccountReportColumns { get; } = new List<AccountReportColumn>();

    //public virtual ICollection<AccountReportLine> AccountReportLines { get; } = new List<AccountReportLine>();

    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<AccountReport> InverseRootReport { get; } = new List<AccountReport>();

    public virtual AccountReport? RootReport { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
