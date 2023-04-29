using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountAnalyticPlan
{
    public Guid Id { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? CompanyId { get; set; }

    public long? Color { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? ParentPath { get; set; }

    public string? CompleteName { get; set; }

    public string? DefaultApplicability { get; set; }

    public string? Description { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccountPlans { get; } = new List<AccountAnalyticAccount>();

    public virtual ICollection<AccountAnalyticAccount> AccountAnalyticAccountRootPlans { get; } = new List<AccountAnalyticAccount>();

    public virtual ICollection<AccountAnalyticApplicability> AccountAnalyticApplicabilities { get; } = new List<AccountAnalyticApplicability>();

    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; } = new List<AccountAnalyticLine>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<AccountAnalyticPlan> InverseParent { get; } = new List<AccountAnalyticPlan>();

    public virtual AccountAnalyticPlan? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
