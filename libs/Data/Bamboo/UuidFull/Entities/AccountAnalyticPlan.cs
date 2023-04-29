using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_analytic_plan")]
[Index("ParentPath", Name = "account_analytic_plan_parent_path_index")]
public partial class AccountAnalyticPlan
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("parent_id")]
    public Guid? ParentId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("parent_path")]
    public string? ParentPath { get; set; }

    [Column("complete_name")]
    public string? CompleteName { get; set; }

    [Column("default_applicability")]
    public string? DefaultApplicability { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [InverseProperty("Plan")]
    public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccountPlans { get; } = new List<AccountAnalyticAccount>();

    [InverseProperty("RootPlan")]
    public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccountRootPlans { get; } = new List<AccountAnalyticAccount>();

    [InverseProperty("AnalyticPlan")]
    public virtual ICollection<AccountAnalyticApplicability> AccountAnalyticApplicabilities { get; } = new List<AccountAnalyticApplicability>();

    [InverseProperty("Plan")]
    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountAnalyticPlans")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountAnalyticPlanCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<AccountAnalyticPlan> InverseParent { get; } = new List<AccountAnalyticPlan>();

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual AccountAnalyticPlan? Parent { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountAnalyticPlanWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
