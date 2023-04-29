using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrDepartment
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? ManagerId { get; set; }

    public long? Color { get; set; }

    public Guid? MasterDepartmentId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? CompleteName { get; set; }

    public string? ParentPath { get; set; }

    public string? Note { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    public virtual ICollection<HrContract> HrContracts { get; } = new List<HrContract>();

    public virtual ICollection<HrEmployeeSkillLog> HrEmployeeSkillLogs { get; } = new List<HrEmployeeSkillLog>();

    public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; } = new List<HrExpenseSheet>();

    public virtual ICollection<HrJob> HrJobs { get; } = new List<HrJob>();

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocations { get; } = new List<HrLeaveAllocation>();

    public virtual ICollection<HrLeave> HrLeaves { get; } = new List<HrLeave>();

    public virtual ICollection<HrPlan> HrPlans { get; } = new List<HrPlan>();

    public virtual ICollection<HrDepartment> InverseMasterDepartment { get; } = new List<HrDepartment>();

    public virtual ICollection<HrDepartment> InverseParent { get; } = new List<HrDepartment>();

    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipments { get; } = new List<MaintenanceEquipment>();

    public virtual HrEmployee? Manager { get; set; }

    public virtual HrDepartment? MasterDepartment { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual HrDepartment? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrLeaveStressDay> HrLeaveStressDays { get; } = new List<HrLeaveStressDay>();

    public virtual ICollection<MailChannel> MailChannels { get; } = new List<MailChannel>();
}
