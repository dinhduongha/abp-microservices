using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrLeaveAccrualLevel
{
    public Guid Id { get; set; }

    public Guid? Sequence { get; set; }

    public Guid? AccrualPlanId { get; set; }

    public Guid? StartCount { get; set; }

    public Guid? FirstDay { get; set; }

    public Guid? SecondDay { get; set; }

    public Guid? FirstMonthDay { get; set; }

    public Guid? SecondMonthDay { get; set; }

    public Guid? YearlyDay { get; set; }

    public long? ParentId { get; set; }

    public Guid? PostponeMaxDays { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? StartType { get; set; }

    public string? AddedValueType { get; set; }

    public string? Frequency { get; set; }

    public string? WeekDay { get; set; }

    public string? FirstMonth { get; set; }

    public string? SecondMonth { get; set; }

    public string? YearlyMonth { get; set; }

    public string? ActionWithUnusedAccruals { get; set; }

    public bool? IsBasedOnWorkedTime { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? AddedValue { get; set; }

    public double? MaximumLeave { get; set; }

    public virtual HrLeaveAccrualPlan? AccrualPlan { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
