using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_financial_report")]
public partial class AccountFinancialReport
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("parent_id")]
    public Guid? ParentId { get; set; }

    [Column("sequence")]
    public long? Sequence { get; set; }

    [Column("level")]
    public long? Level { get; set; }

    [Column("account_report_id")]
    public Guid? AccountReportId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("type")]
    public string? Type { get; set; }

    [Column("report_domain")]
    public string? ReportDomain { get; set; }

    [Column("sign")]
    public string? Sign { get; set; }

    [Column("display_detail")]
    public string? DisplayDetail { get; set; }

    [Column("style_overwrite")]
    public string? StyleOverwrite { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [InverseProperty("Report")]
    public virtual ICollection<AccountAccountFinancialReportType> AccountAccountFinancialReportTypes { get; } = new List<AccountAccountFinancialReportType>();

    [ForeignKey("AccountReportId")]
    [InverseProperty("InverseAccountReport")]
    public virtual AccountFinancialReport? AccountReport { get; set; }

    [InverseProperty("AccountReport")]
    public virtual ICollection<AccountingReport> AccountingReports { get; } = new List<AccountingReport>();

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountFinancialReportCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("AccountReport")]
    public virtual ICollection<AccountFinancialReport> InverseAccountReport { get; } = new List<AccountFinancialReport>();

    [InverseProperty("Parent")]
    public virtual ICollection<AccountFinancialReport> InverseParent { get; } = new List<AccountFinancialReport>();

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual AccountFinancialReport? Parent { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountFinancialReportWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ReportLineId")]
    [InverseProperty("ReportLines2")]
    public virtual ICollection<AccountAccount> Accounts { get; } = new List<AccountAccount>();
}
