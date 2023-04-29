using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("ReportId", "AccountTypeId")]
[Table("account_account_financial_report_type")]
[Index("AccountTypeId", "ReportId", Name = "account_account_financial_report__account_type_id_report_id_idx")]
public partial class AccountAccountFinancialReportType
{
    [Key]
    [Column("report_id")]
    public Guid ReportId { get; set; }

    [Key]
    [Column("account_type_id")]
    public long AccountTypeId { get; set; }

    [ForeignKey("ReportId")]
    [InverseProperty("AccountAccountFinancialReportTypes")]
    public virtual AccountFinancialReport Report { get; set; } = null!;
}
