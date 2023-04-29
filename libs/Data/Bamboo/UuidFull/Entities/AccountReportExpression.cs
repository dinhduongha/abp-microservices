using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_report_expression")]
public partial class AccountReportExpression
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("report_line_id")]
    public Guid? ReportLineId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("label")]
    public string? Label { get; set; }

    [Column("engine")]
    public string? Engine { get; set; }

    [Column("formula")]
    public string? Formula { get; set; }

    [Column("subformula")]
    public string? Subformula { get; set; }

    [Column("date_scope")]
    public string? DateScope { get; set; }

    [Column("figure_type")]
    public string? FigureType { get; set; }

    [Column("carryover_target")]
    public string? CarryoverTarget { get; set; }

    [Column("green_on_positive")]
    public bool? GreenOnPositive { get; set; }

    [Column("blank_if_zero")]
    public bool? BlankIfZero { get; set; }

    [Column("auditable")]
    public bool? Auditable { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [InverseProperty("TargetReportExpression")]
    public virtual ICollection<AccountReportExternalValue> AccountReportExternalValues { get; } = new List<AccountReportExternalValue>();

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountReportExpressionCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ReportLineId")]
    [InverseProperty("AccountReportExpressions")]
    public virtual AccountReportLine? ReportLine { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountReportExpressionWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountReportExpressionId")]
    [InverseProperty("AccountReportExpressions")]
    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplates { get; } = new List<AccountTaxRepartitionLineTemplate>();

    [ForeignKey("AccountReportExpressionId")]
    [InverseProperty("AccountReportExpressionsNavigation")]
    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplatesNavigation { get; } = new List<AccountTaxRepartitionLineTemplate>();
}
