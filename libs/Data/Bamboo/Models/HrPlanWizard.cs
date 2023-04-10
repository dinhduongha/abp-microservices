using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrPlanWizard
{
    public Guid Id { get; set; }

    public Guid? PlanId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrPlan? Plan { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<HrEmployee> PlanWizards { get; } = new List<HrEmployee>();
}
