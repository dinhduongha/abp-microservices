using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("account_report_line")]
[Index("Code", Name = "account_report_line_code_uniq", IsUnique = true)]
public partial class AccountReportLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("report_id")]
    public Guid? ReportId { get; set; }

    [Column("hierarchy_level")]
    public long? HierarchyLevel { get; set; }

    [Column("parent_id")]
    public Guid? ParentId { get; set; }

    [Column("sequence")]
    public long? Sequence { get; set; }

    [Column("action_id")]
    public Guid? ActionId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("groupby")]
    public string? Groupby { get; set; }

    [Column("code")]
    public string? Code { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("foldable")]
    public bool? Foldable { get; set; }

    [Column("print_on_new_page")]
    public bool? PrintOnNewPage { get; set; }

    [Column("hide_if_zero")]
    public bool? HideIfZero { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [InverseProperty("ReportLine")]
    public virtual ICollection<AccountReportExpression> AccountReportExpressions { get; } = new List<AccountReportExpression>();

    [InverseProperty("CarryoverOriginReportLine")]
    public virtual ICollection<AccountReportExternalValue> AccountReportExternalValues { get; } = new List<AccountReportExternalValue>();

    [ForeignKey("CreatorId")]
    [InverseProperty("AccountReportLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<AccountReportLine> InverseParent { get; } = new List<AccountReportLine>();

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual AccountReportLine? Parent { get; set; }

    [ForeignKey("ReportId")]
    [InverseProperty("AccountReportLines")]
    public virtual AccountReport? Report { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("AccountReportLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
