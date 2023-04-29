using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ResourceCalendarLeaf
{
    public Guid Id { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CalendarId { get; set; }

    public Guid? ResourceId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? TimeType { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? HolidayId { get; set; }

    public virtual ResourceCalendar? Calendar { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrLeave? Holiday { get; set; }

    public virtual ICollection<MrpWorkorder> MrpWorkorders { get; } = new List<MrpWorkorder>();

    public virtual ResourceResource? Resource { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
