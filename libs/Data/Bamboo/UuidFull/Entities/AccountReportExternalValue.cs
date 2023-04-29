using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_report_external_value")]
public partial class AccountReportExternalValue
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("target_report_expression_id")]
    public Guid? TargetReportExpressionId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("foreign_vat_fiscal_position_id")]
    public Guid? ForeignVatFiscalPositionId { get; set; }

    [Column("carryover_origin_report_line_id")]
    public Guid? CarryoverOriginReportLineId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("carryover_origin_expression_label")]
    public string? CarryoverOriginExpressionLabel { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("value")]
    public double? Value { get; set; }

    [ForeignKey("CarryoverOriginReportLineId")]
    [InverseProperty("AccountReportExternalValues")]
    public virtual AccountReportLine? CarryoverOriginReportLine { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountReportExternalValues")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountReportExternalValueCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ForeignVatFiscalPositionId")]
    [InverseProperty("AccountReportExternalValues")]
    public virtual AccountFiscalPosition? ForeignVatFiscalPosition { get; set; }

    [ForeignKey("TargetReportExpressionId")]
    [InverseProperty("AccountReportExternalValues")]
    public virtual AccountReportExpression? TargetReportExpression { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountReportExternalValueWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
