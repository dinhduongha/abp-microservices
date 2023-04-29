using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrPlanActivityType
{
    public Guid Id { get; set; }

    public Guid? CompanyId { get; set; }

    public long? ActivityTypeId { get; set; }

    public Guid? ResponsibleId { get; set; }

    public Guid? PlanId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Summary { get; set; }

    public string? Responsible { get; set; }

    public string? Note { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrPlan? Plan { get; set; }

    public virtual ResUser? ResponsibleNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
