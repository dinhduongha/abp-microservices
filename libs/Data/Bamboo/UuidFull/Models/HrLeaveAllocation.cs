using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrLeaveAllocation
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public long? HolidayStatusId { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? EmployeeCompanyId { get; set; }

    public Guid? ManagerId { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? ApproverId { get; set; }

    public Guid? ModeCompanyId { get; set; }

    public Guid? DepartmentId { get; set; }

    public long? CategoryId { get; set; }

    public Guid? AccrualPlanId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? PrivateName { get; set; }

    public string? State { get; set; }

    public string? HolidayType { get; set; }

    public string? AllocationType { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateOnly? DateTo { get; set; }

    public DateOnly? Lastcall { get; set; }

    public DateOnly? Nextcall { get; set; }

    public string? Notes { get; set; }

    public bool? Active { get; set; }

    public bool? MultiEmployee { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? NumberOfDays { get; set; }

    public Guid? OvertimeId { get; set; }

    public virtual HrLeaveAccrualPlan? AccrualPlan { get; set; }

    public virtual HrEmployee? Approver { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual ResCompany? EmployeeCompany { get; set; }

    public virtual ICollection<HrLeave> HrLeaves { get; } = new List<HrLeave>();

    public virtual ICollection<HrLeaveAllocation> InverseParent { get; } = new List<HrLeaveAllocation>();

    public virtual HrEmployee? Manager { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResCompany? ModeCompany { get; set; }

    public virtual HrAttendanceOvertime? Overtime { get; set; }

    public virtual HrLeaveAllocation? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();
}
