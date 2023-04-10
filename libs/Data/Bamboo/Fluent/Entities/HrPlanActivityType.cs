using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrPlanActivityType
{
    public long Id { get; set; }

    public Guid? TenantId { get; set; }

    public long? ActivityTypeId { get; set; }

    public Guid? ResponsibleId { get; set; }

    public Guid? PlanId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Summary { get; set; }

    public string? Responsible { get; set; }

    public string? Note { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual MailActivityType? ActivityType { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrPlan? Plan { get; set; }

    public virtual ResUser? ResponsibleNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
