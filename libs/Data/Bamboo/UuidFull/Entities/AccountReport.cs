using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_report")]
public partial class AccountReport
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("root_report_id")]
    public Guid? RootReportId { get; set; }

    [Column("chart_template_id")]
    public Guid? ChartTemplateId { get; set; }

    [Column("country_id")]
    public long? CountryId { get; set; }

    [Column("load_more_limit")]
    public long? LoadMoreLimit { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("availability_condition")]
    public string? AvailabilityCondition { get; set; }

    [Column("default_opening_date_filter")]
    public string? DefaultOpeningDateFilter { get; set; }

    [Column("filter_multi_company")]
    public string? FilterMultiCompany { get; set; }

    [Column("filter_hierarchy")]
    public string? FilterHierarchy { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("only_tax_exigible")]
    public bool? OnlyTaxExigible { get; set; }

    [Column("search_bar")]
    public bool? SearchBar { get; set; }

    [Column("filter_date_range")]
    public bool? FilterDateRange { get; set; }

    [Column("filter_show_draft")]
    public bool? FilterShowDraft { get; set; }

    [Column("filter_unreconciled")]
    public bool? FilterUnreconciled { get; set; }

    [Column("filter_unfold_all")]
    public bool? FilterUnfoldAll { get; set; }

    [Column("filter_period_comparison")]
    public bool? FilterPeriodComparison { get; set; }

    [Column("filter_growth_comparison")]
    public bool? FilterGrowthComparison { get; set; }

    [Column("filter_journals")]
    public bool? FilterJournals { get; set; }

    [Column("filter_analytic")]
    public bool? FilterAnalytic { get; set; }

    [Column("filter_account_type")]
    public bool? FilterAccountType { get; set; }

    [Column("filter_partner")]
    public bool? FilterPartner { get; set; }

    [Column("filter_fiscal_position")]
    public bool? FilterFiscalPosition { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [InverseProperty("Report")]
    public virtual ICollection<AccountReportColumn> AccountReportColumns { get; } = new List<AccountReportColumn>();

    [InverseProperty("Report")]
    public virtual ICollection<AccountReportLine> AccountReportLines { get; } = new List<AccountReportLine>();

    [ForeignKey("ChartTemplateId")]
    [InverseProperty("AccountReports")]
    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountReportCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("RootReport")]
    public virtual ICollection<AccountReport> InverseRootReport { get; } = new List<AccountReport>();

    [ForeignKey("RootReportId")]
    [InverseProperty("InverseRootReport")]
    public virtual AccountReport? RootReport { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountReportWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
