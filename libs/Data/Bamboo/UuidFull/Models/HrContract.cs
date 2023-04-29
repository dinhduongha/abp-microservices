using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrContract
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public long? StructureTypeId { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? DepartmentId { get; set; }

    public Guid? JobId { get; set; }

    public Guid? ResourceCalendarId { get; set; }

    public Guid? CompanyId { get; set; }

    public long? ContractTypeId { get; set; }

    public Guid? HrResponsibleId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? State { get; set; }

    public string? KanbanState { get; set; }

    public DateOnly? DateStart { get; set; }

    public DateOnly? DateEnd { get; set; }

    public DateOnly? TrialDateEnd { get; set; }

    public string? Notes { get; set; }

    public decimal? Wage { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    public virtual ResUser? HrResponsible { get; set; }

    public virtual HrJob? Job { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResourceCalendar? ResourceCalendar { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
