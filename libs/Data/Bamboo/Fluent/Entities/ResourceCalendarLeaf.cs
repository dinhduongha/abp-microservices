using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ResourceCalendarLeaf
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CalendarId { get; set; }

    public Guid? ResourceId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? TimeType { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? HolidayId { get; set; }

    public virtual ResourceCalendar? Calendar { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrLeave? Holiday { get; set; }

    //public virtual ICollection<MrpWorkorder> MrpWorkorders { get; } = new List<MrpWorkorder>();

    public virtual ResourceResource? Resource { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
