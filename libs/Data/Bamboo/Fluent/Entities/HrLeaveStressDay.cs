using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrLeaveStressDay
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public long? Color { get; set; }

    public Guid? ResourceCalendarId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResourceCalendar? ResourceCalendar { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<HrDepartment> HrDepartments { get; } = new List<HrDepartment>();
}
