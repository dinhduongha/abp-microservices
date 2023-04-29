using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_analytic_account")]
[Index("Code", Name = "account_analytic_account_code_index")]
public partial class AccountAnalyticAccount
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("plan_id")]
    public Guid? PlanId { get; set; }

    [Column("root_plan_id")]
    public Guid? RootPlanId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("code")]
    public string? Code { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [InverseProperty("Account")]
    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    [InverseProperty("AccountAnalytic")]
    public virtual ICollection<AccountAssetAsset> AccountAssetAssets { get; } = new List<AccountAssetAsset>();

    [InverseProperty("AccountAnalytic")]
    public virtual ICollection<AccountAssetCategory> AccountAssetCategories { get; } = new List<AccountAssetCategory>();

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountAnalyticAccounts")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountAnalyticAccountCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("AnalyticAccount")]
    public virtual ICollection<CrossoveredBudgetLine> CrossoveredBudgetLines { get; } = new List<CrossoveredBudgetLine>();

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("AccountAnalyticAccounts")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [InverseProperty("AnalyticAccount")]
    public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();

    [InverseProperty("CostsHourAccount")]
    public virtual ICollection<MrpWorkcenter> MrpWorkcenters { get; } = new List<MrpWorkcenter>();

    [ForeignKey("PartnerId")]
    [InverseProperty("AccountAnalyticAccounts")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("PlanId")]
    [InverseProperty("AccountAnalyticAccountPlans")]
    public virtual AccountAnalyticPlan? Plan { get; set; }

    [InverseProperty("AnalyticAccount")]
    public virtual ICollection<ProjectProject> ProjectProjects { get; } = new List<ProjectProject>();

    [InverseProperty("AnalyticAccount")]
    public virtual ICollection<ProjectTask> ProjectTasks { get; } = new List<ProjectTask>();

    [ForeignKey("RootPlanId")]
    [InverseProperty("AccountAnalyticAccountRootPlans")]
    public virtual AccountAnalyticPlan? RootPlan { get; set; }

    [InverseProperty("AnalyticAccount")]
    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountAnalyticAccountWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountAnalyticAccountId")]
    [InverseProperty("AccountAnalyticAccounts")]
    public virtual ICollection<AccountBalanceReport> AccountBalanceReports { get; } = new List<AccountBalanceReport>();

    [ForeignKey("AccountAnalyticAccountId")]
    [InverseProperty("AccountAnalyticAccounts")]
    public virtual ICollection<AccountCommonAccountReport> AccountCommonAccountReports { get; } = new List<AccountCommonAccountReport>();

    [ForeignKey("AccountAnalyticAccountId")]
    [InverseProperty("AccountAnalyticAccounts")]
    public virtual ICollection<AccountReportGeneralLedger> AccountReportGeneralLedgers { get; } = new List<AccountReportGeneralLedger>();
}
