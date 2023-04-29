using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("hr_leave_allocation")]
[Index("DateFrom", Name = "hr_leave_allocation_date_from_index")]
[Index("EmployeeId", Name = "hr_leave_allocation_employee_id_index")]
public partial class HrLeaveAllocation
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("holiday_status_id")]
    public long? HolidayStatusId { get; set; }

    [Column("employee_id")]
    public Guid? EmployeeId { get; set; }

    [Column("employee_company_id")]
    public Guid? EmployeeCompanyId { get; set; }

    [Column("manager_id")]
    public Guid? ManagerId { get; set; }

    [Column("parent_id")]
    public Guid? ParentId { get; set; }

    [Column("approver_id")]
    public Guid? ApproverId { get; set; }

    [Column("mode_company_id")]
    public Guid? ModeCompanyId { get; set; }

    [Column("department_id")]
    public Guid? DepartmentId { get; set; }

    [Column("category_id")]
    public long? CategoryId { get; set; }

    [Column("accrual_plan_id")]
    public Guid? AccrualPlanId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("private_name")]
    public string? PrivateName { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("holiday_type")]
    public string? HolidayType { get; set; }

    [Column("allocation_type")]
    public string? AllocationType { get; set; }

    [Column("date_from")]
    public DateOnly? DateFrom { get; set; }

    [Column("date_to")]
    public DateOnly? DateTo { get; set; }

    [Column("lastcall")]
    public DateOnly? Lastcall { get; set; }

    [Column("nextcall")]
    public DateOnly? Nextcall { get; set; }

    [Column("notes")]
    public string? Notes { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("multi_employee")]
    public bool? MultiEmployee { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("number_of_days")]
    public double? NumberOfDays { get; set; }

    [Column("overtime_id")]
    public Guid? OvertimeId { get; set; }

    [ForeignKey("AccrualPlanId")]
    //[InverseProperty("HrLeaveAllocations")]
    public virtual HrLeaveAccrualPlan? AccrualPlan { get; set; }

    [ForeignKey("ApproverId")]
    //[InverseProperty("HrLeaveAllocationApprovers")]
    public virtual HrEmployee? Approver { get; set; }

    [ForeignKey("CategoryId")]
    //[InverseProperty("HrLeaveAllocations")]
    public virtual HrEmployeeCategory? Category { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("HrLeaveAllocationCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("DepartmentId")]
    //[InverseProperty("HrLeaveAllocations")]
    public virtual HrDepartment? Department { get; set; }

    [ForeignKey("EmployeeId")]
    //[InverseProperty("HrLeaveAllocationEmployees")]
    public virtual HrEmployee? Employee { get; set; }

    [ForeignKey("EmployeeCompanyId")]
    //[InverseProperty("HrLeaveAllocationEmployeeCompanies")]
    public virtual ResCompany? EmployeeCompany { get; set; }

    [ForeignKey("HolidayStatusId")]
    //[InverseProperty("HrLeaveAllocations")]
    public virtual HrLeaveType? HolidayStatus { get; set; }

    [ForeignKey("ManagerId")]
    //[InverseProperty("HrLeaveAllocationManagers")]
    public virtual HrEmployee? Manager { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    //[InverseProperty("HrLeaveAllocations")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("ModeCompanyId")]
    //[InverseProperty("HrLeaveAllocationModeCompanies")]
    public virtual ResCompany? ModeCompany { get; set; }

    [ForeignKey("OvertimeId")]
    //[InverseProperty("HrLeaveAllocations")]
    public virtual HrAttendanceOvertime? Overtime { get; set; }

    [ForeignKey("ParentId")]
    //[InverseProperty("InverseParent")]
    public virtual HrLeaveAllocation? Parent { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("HrLeaveAllocationWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("HolidayAllocation")]
    [NotMapped]
    public virtual ICollection<HrLeave> HrLeaves { get; } = new List<HrLeave>();

    [InverseProperty("Parent")]
    [NotMapped]
    public virtual ICollection<HrLeaveAllocation> InverseParent { get; } = new List<HrLeaveAllocation>();

    [ForeignKey("HrLeaveAllocationId")]
    [InverseProperty("HrLeaveAllocations")]
    [NotMapped]
    public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();
}
