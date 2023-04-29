using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrLeaveStressDay
{
    public Guid Id { get; set; }

    public Guid? CompanyId { get; set; }

    public long? Color { get; set; }

    public Guid? ResourceCalendarId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResourceCalendar? ResourceCalendar { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrDepartment> HrDepartments { get; } = new List<HrDepartment>();
}
