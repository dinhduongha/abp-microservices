using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrLeave
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? ManagerId { get; set; }

    public long? HolidayStatusId { get; set; }

    public Guid? HolidayAllocationId { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? EmployeeCompanyId { get; set; }

    public Guid? DepartmentId { get; set; }

    public Guid? MeetingId { get; set; }

    public Guid? ParentId { get; set; }

    public long? CategoryId { get; set; }

    public Guid? ModeCompanyId { get; set; }

    public Guid? FirstApproverId { get; set; }

    public Guid? SecondApproverId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? PrivateName { get; set; }

    public string? State { get; set; }

    public string? DurationDisplay { get; set; }

    public string? HolidayType { get; set; }

    public string? RequestHourFrom { get; set; }

    public string? RequestHourTo { get; set; }

    public string? RequestDateFromPeriod { get; set; }

    public DateOnly? RequestDateFrom { get; set; }

    public DateOnly? RequestDateTo { get; set; }

    public string? ReportNote { get; set; }

    public string? Notes { get; set; }

    public bool? Active { get; set; }

    public bool? MultiEmployee { get; set; }

    public bool? RequestUnitHalf { get; set; }

    public bool? RequestUnitHours { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? NumberOfDays { get; set; }

    public Guid? OvertimeId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual ResCompany? EmployeeCompany { get; set; }

    public virtual HrEmployee? FirstApprover { get; set; }

    public virtual HrLeaveAllocation? HolidayAllocation { get; set; }

    public virtual ICollection<HrHolidaysCancelLeave> HrHolidaysCancelLeaves { get; } = new List<HrHolidaysCancelLeave>();

    public virtual ICollection<HrLeave> InverseParent { get; } = new List<HrLeave>();

    public virtual HrEmployee? Manager { get; set; }

    public virtual CalendarEvent? Meeting { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResCompany? ModeCompany { get; set; }

    public virtual HrAttendanceOvertime? Overtime { get; set; }

    public virtual HrLeave? Parent { get; set; }

    public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeaves { get; } = new List<ResourceCalendarLeaf>();

    public virtual HrEmployee? SecondApprover { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();
}
