﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_report_column")]
public partial class AccountReportColumn
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long? Sequence { get; set; }

    [Column("report_id")]
    public Guid? ReportId { get; set; }

    [Column("custom_audit_action_id")]
    public Guid? CustomAuditActionId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("expression_label")]
    public string? ExpressionLabel { get; set; }

    [Column("figure_type")]
    public string? FigureType { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("sortable")]
    public bool? Sortable { get; set; }

    [Column("blank_if_zero")]
    public bool? BlankIfZero { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountReportColumnCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CustomAuditActionId")]
    [InverseProperty("AccountReportColumns")]
    public virtual IrActWindow? CustomAuditAction { get; set; }

    [ForeignKey("ReportId")]
    [InverseProperty("AccountReportColumns")]
    public virtual AccountReport? Report { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountReportColumnWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}