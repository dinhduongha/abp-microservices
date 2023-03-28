using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountAnalyticApplicability
{
    public Guid Id { get; set; }

    public Guid? AnalyticPlanId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? BusinessDomain { get; set; }

    public string? Applicability { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? ProductCategId { get; set; }

    public string? AccountPrefix { get; set; }

    public virtual AccountAnalyticPlan? AnalyticPlan { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductCategory? ProductCateg { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
