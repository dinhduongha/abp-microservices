using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrPlan
{
    public Guid Id { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? DepartmentId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual ICollection<HrPlanActivityType> HrPlanActivityTypes { get; } = new List<HrPlanActivityType>();

    public virtual ICollection<HrPlanWizard> HrPlanWizards { get; } = new List<HrPlanWizard>();

    public virtual ResUser? WriteU { get; set; }
}
