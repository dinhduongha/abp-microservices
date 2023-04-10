using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrAttendanceOvertime
{
    public Guid Id { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateOnly? Date { get; set; }

    public bool? Adjustment { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? Duration { get; set; }

    public double? DurationReal { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    //public virtual ICollection<HrLeaveAllocation> HrLeaveAllocations { get; } = new List<HrLeaveAllocation>();

    //public virtual ICollection<HrLeave> HrLeaves { get; } = new List<HrLeave>();

    public virtual ResUser? WriteU { get; set; }
}
