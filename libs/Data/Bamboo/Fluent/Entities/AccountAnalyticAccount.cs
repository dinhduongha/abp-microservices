using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountAnalyticAccount
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? PlanId { get; set; }

    public Guid? RootPlanId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    //public virtual ICollection<AccountAssetAsset> AccountAssetAssets { get; } = new List<AccountAssetAsset>();

    //public virtual ICollection<AccountAssetCategory> AccountAssetCategories { get; } = new List<AccountAssetCategory>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<CrossoveredBudgetLine> CrossoveredBudgetLines { get; } = new List<CrossoveredBudgetLine>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    //public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();

    //public virtual ICollection<MrpWorkcenter> MrpWorkcenters { get; } = new List<MrpWorkcenter>();

    public virtual ResPartner? Partner { get; set; }

    public virtual AccountAnalyticPlan? Plan { get; set; }

    //public virtual ICollection<ProjectProject> ProjectProjects { get; } = new List<ProjectProject>();

    //public virtual ICollection<ProjectTask> ProjectTasks { get; } = new List<ProjectTask>();

    public virtual AccountAnalyticPlan? RootPlan { get; set; }

    //public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountBalanceReport> AccountBalanceReports { get; } = new List<AccountBalanceReport>();

    //public virtual ICollection<AccountCommonAccountReport> AccountCommonAccountReports { get; } = new List<AccountCommonAccountReport>();

    //public virtual ICollection<AccountReportGeneralLedger> AccountReportGeneralLedgers { get; } = new List<AccountReportGeneralLedger>();
}
