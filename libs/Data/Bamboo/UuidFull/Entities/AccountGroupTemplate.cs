using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_group_template")]
public partial class AccountGroupTemplate
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("parent_id")]
    public Guid? ParentId { get; set; }

    [Column("chart_template_id")]
    public Guid? ChartTemplateId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("code_prefix_start")]
    public string? CodePrefixStart { get; set; }

    [Column("code_prefix_end")]
    public string? CodePrefixEnd { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("ChartTemplateId")]
    [InverseProperty("AccountGroupTemplates")]
    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountGroupTemplateCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<AccountGroupTemplate> InverseParent { get; } = new List<AccountGroupTemplate>();

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual AccountGroupTemplate? Parent { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountGroupTemplateWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
