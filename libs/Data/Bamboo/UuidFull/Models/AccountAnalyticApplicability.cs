using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountAnalyticApplicability
{
    public Guid Id { get; set; }

    public Guid? AnalyticPlanId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? BusinessDomain { get; set; }

    public string? Applicability { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public long? ProductCategId { get; set; }

    public string? AccountPrefix { get; set; }

    public virtual AccountAnalyticPlan? AnalyticPlan { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
