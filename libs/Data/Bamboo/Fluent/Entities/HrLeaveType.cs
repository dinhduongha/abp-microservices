using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrLeaveType
{
    public long Id { get; set; }

    public long Sequence { get; set; }

    public long? Color { get; set; }

    public Guid? IconId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? ResponsibleId { get; set; }

    public long? LeaveNotifSubtypeId { get; set; }

    public long? AllocationNotifSubtypeId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? ColorName { get; set; }

    public string? LeaveValidationType { get; set; }

    public string? RequiresAllocation { get; set; }

    public string? EmployeeRequests { get; set; }

    public string? AllocationValidationType { get; set; }

    public string? TimeType { get; set; }

    public string? RequestUnit { get; set; }

    public string? Name { get; set; }

    public bool? CreateCalendarMeeting { get; set; }

    public bool? Active { get; set; }

    public bool? Unpaid { get; set; }

    public bool? SupportDocument { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public bool? OvertimeDeductible { get; set; }

    public virtual MailMessageSubtype? AllocationNotifSubtype { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<HrLeaveAccrualPlan> HrLeaveAccrualPlans { get; } = new List<HrLeaveAccrualPlan>();

    //public virtual ICollection<HrLeaveAllocation> HrLeaveAllocations { get; } = new List<HrLeaveAllocation>();

    //public virtual ICollection<HrLeave> HrLeaves { get; } = new List<HrLeave>();

    public virtual IrAttachment? Icon { get; set; }

    public virtual MailMessageSubtype? LeaveNotifSubtype { get; set; }

    public virtual ResUser? Responsible { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
