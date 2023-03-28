using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrLeaveAccrualPlan
{
    public Guid Id { get; set; }

    public long? TimeOffTypeId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? TransitionMode { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<HrLeaveAccrualLevel> HrLeaveAccrualLevels { get; } = new List<HrLeaveAccrualLevel>();

    //public virtual ICollection<HrLeaveAllocation> HrLeaveAllocations { get; } = new List<HrLeaveAllocation>();

    public virtual HrLeaveType? TimeOffType { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
