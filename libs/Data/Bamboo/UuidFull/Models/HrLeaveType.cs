using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrLeaveType
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public long? Color { get; set; }

    public Guid? IconId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? ResponsibleId { get; set; }

    public long? LeaveNotifSubtypeId { get; set; }

    public long? AllocationNotifSubtypeId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

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

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public bool? OvertimeDeductible { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrAttachment? Icon { get; set; }

    public virtual ResUser? Responsible { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
