using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("accounting_report")]
public partial class AccountingReport
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("account_report_id")]
    public Guid? AccountReportId { get; set; }

    [Column("target_move")]
    public string? TargetMove { get; set; }

    [Column("label_filter")]
    public string? LabelFilter { get; set; }

    [Column("filter_cmp")]
    public string? FilterCmp { get; set; }

    [Column("date_from")]
    public DateOnly? DateFrom { get; set; }

    [Column("date_to")]
    public DateOnly? DateTo { get; set; }

    [Column("date_from_cmp")]
    public DateOnly? DateFromCmp { get; set; }

    [Column("date_to_cmp")]
    public DateOnly? DateToCmp { get; set; }

    [Column("enable_filter")]
    public bool? EnableFilter { get; set; }

    [Column("debit_credit")]
    public bool? DebitCredit { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("AccountReportId")]
    [InverseProperty("AccountingReports")]
    public virtual AccountFinancialReport? AccountReport { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountingReports")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountingReportCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountingReportWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountingReportId")]
    [InverseProperty("AccountingReports")]
    public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();
}
