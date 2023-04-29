using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrAttendanceOvertime
{
    public Guid Id { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateOnly? Date { get; set; }

    public bool? Adjustment { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? Duration { get; set; }

    public double? DurationReal { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocations { get; } = new List<HrLeaveAllocation>();

    public virtual ICollection<HrLeave> HrLeaves { get; } = new List<HrLeave>();

    public virtual ResUser? WriteU { get; set; }
}
