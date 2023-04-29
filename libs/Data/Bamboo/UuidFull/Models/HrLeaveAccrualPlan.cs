using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrLeaveAccrualPlan
{
    public Guid Id { get; set; }

    public long? TimeOffTypeId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? TransitionMode { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrLeaveAccrualLevel> HrLeaveAccrualLevels { get; } = new List<HrLeaveAccrualLevel>();

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocations { get; } = new List<HrLeaveAllocation>();

    public virtual ResUser? WriteU { get; set; }
}
