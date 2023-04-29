using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrEmployee
{
    public Guid Id { get; set; }

    public Guid? ResourceId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? ResourceCalendarId { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public long? Color { get; set; }

    public Guid? DepartmentId { get; set; }

    public Guid? JobId { get; set; }

    public Guid? AddressId { get; set; }

    public Guid? WorkContactId { get; set; }

    public Guid? WorkLocationId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? CoachId { get; set; }

    public Guid? AddressHomeId { get; set; }

    public long? CountryId { get; set; }

    public long? Children { get; set; }

    public long? CountryOfBirth { get; set; }

    public Guid? BankAccountId { get; set; }

    public long? KmHomeWork { get; set; }

    public long? DepartureReasonId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? JobTitle { get; set; }

    public string? WorkPhone { get; set; }

    public string? MobilePhone { get; set; }

    public string? WorkEmail { get; set; }

    public string? EmployeeType { get; set; }

    public string? Gender { get; set; }

    public string? Marital { get; set; }

    public string? SpouseCompleteName { get; set; }

    public string? PlaceOfBirth { get; set; }

    public string? Ssnid { get; set; }

    public string? Sinid { get; set; }

    public string? IdentificationId { get; set; }

    public string? PassportId { get; set; }

    public string? PermitNo { get; set; }

    public string? VisaNo { get; set; }

    public string? Certificate { get; set; }

    public string? StudyField { get; set; }

    public string? StudySchool { get; set; }

    public string? EmergencyContact { get; set; }

    public string? EmergencyPhone { get; set; }

    public string? Barcode { get; set; }

    public string? Pin { get; set; }

    public DateOnly? SpouseBirthdate { get; set; }

    public DateOnly? Birthday { get; set; }

    public DateOnly? VisaExpire { get; set; }

    public DateOnly? WorkPermitExpirationDate { get; set; }

    public DateOnly? DepartureDate { get; set; }

    public string? AdditionalNote { get; set; }

    public string? Notes { get; set; }

    public string? DepartureDescription { get; set; }

    public bool? Active { get; set; }

    public bool? WorkPermitScheduledActivity { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? ContractId { get; set; }

    public string? Vehicle { get; set; }

    public DateOnly? FirstContractDate { get; set; }

    public bool? ContractWarning { get; set; }

    public string? MobilityCard { get; set; }

    public Guid? ExpenseManagerId { get; set; }

    public Guid? LeaveManagerId { get; set; }

    public Guid? LastAttendanceId { get; set; }

    public DateTime? LastCheckIn { get; set; }

    public DateTime? LastCheckOut { get; set; }

    public virtual ResPartner? Address { get; set; }

    public virtual ResPartner? AddressHome { get; set; }

    public virtual ResPartnerBank? BankAccount { get; set; }

    public virtual HrEmployee? Coach { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual HrContract? Contract { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual ICollection<EmployeeCategoryRel> EmployeeCategoryRels { get; } = new List<EmployeeCategoryRel>();

    public virtual ResUser? ExpenseManager { get; set; }

    public virtual ICollection<FleetVehicleAssignationLog> FleetVehicleAssignationLogs { get; } = new List<FleetVehicleAssignationLog>();

    public virtual ICollection<FleetVehicle> FleetVehicleDriverEmployees { get; } = new List<FleetVehicle>();

    public virtual ICollection<FleetVehicle> FleetVehicleFutureDriverEmployees { get; } = new List<FleetVehicle>();

    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServices { get; } = new List<FleetVehicleLogService>();

    public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    public virtual ICollection<HrAttendanceOvertime> HrAttendanceOvertimes { get; } = new List<HrAttendanceOvertime>();

    public virtual ICollection<HrAttendance> HrAttendances { get; } = new List<HrAttendance>();

    public virtual ICollection<HrContract> HrContracts { get; } = new List<HrContract>();

    public virtual ICollection<HrDepartment> HrDepartments { get; } = new List<HrDepartment>();

    public virtual ICollection<HrDepartureWizard> HrDepartureWizards { get; } = new List<HrDepartureWizard>();

    public virtual ICollection<HrEmployeeSkillLog> HrEmployeeSkillLogs { get; } = new List<HrEmployeeSkillLog>();

    public virtual ICollection<HrEmployeeSkill> HrEmployeeSkills { get; } = new List<HrEmployeeSkill>();

    public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; } = new List<HrExpenseSheet>();

    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; } = new List<HrExpenseSplit>();

    public virtual ICollection<HrExpense> HrExpenses { get; } = new List<HrExpense>();

    public virtual ICollection<HrJob> HrJobs { get; } = new List<HrJob>();

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocationApprovers { get; } = new List<HrLeaveAllocation>();

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocationEmployees { get; } = new List<HrLeaveAllocation>();

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocationManagers { get; } = new List<HrLeaveAllocation>();

    public virtual ICollection<HrLeave> HrLeaveEmployees { get; } = new List<HrLeave>();

    public virtual ICollection<HrLeave> HrLeaveFirstApprovers { get; } = new List<HrLeave>();

    public virtual ICollection<HrLeave> HrLeaveManagers { get; } = new List<HrLeave>();

    public virtual ICollection<HrLeave> HrLeaveSecondApprovers { get; } = new List<HrLeave>();

    public virtual ICollection<HrResumeLine> HrResumeLines { get; } = new List<HrResumeLine>();

    public virtual ICollection<HrEmployee> InverseCoach { get; } = new List<HrEmployee>();

    public virtual ICollection<HrEmployee> InverseParent { get; } = new List<HrEmployee>();

    public virtual HrJob? Job { get; set; }

    public virtual HrAttendance? LastAttendance { get; set; }

    public virtual ResUser? LeaveManager { get; set; }

    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipments { get; } = new List<MaintenanceEquipment>();

    public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; } = new List<MaintenanceRequest>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual HrEmployee? Parent { get; set; }

    public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    public virtual ResourceResource? Resource { get; set; }

    public virtual ResourceCalendar? ResourceCalendar { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResPartner? WorkContact { get; set; }

    public virtual HrWorkLocation? WorkLocation { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrPlanWizard> Employees { get; } = new List<HrPlanWizard>();

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocations { get; } = new List<HrLeaveAllocation>();

    public virtual ICollection<HrLeave> HrLeaves { get; } = new List<HrLeave>();

    public virtual ICollection<HrSkill> HrSkills { get; } = new List<HrSkill>();

    public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();

    public virtual ICollection<HrHolidaysSummaryEmployee> Sums { get; } = new List<HrHolidaysSummaryEmployee>();
}
