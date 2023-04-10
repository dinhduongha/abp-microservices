using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ResourceCalendarAttendance
{
    public Guid Id { get; set; }

    public Guid? CalendarId { get; set; }

    public Guid? ResourceId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Dayofweek { get; set; }

    public string? DayPeriod { get; set; }

    public string? WeekType { get; set; }

    public string? DisplayType { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateOnly? DateTo { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? HourFrom { get; set; }

    public double? HourTo { get; set; }

    public virtual ResourceCalendar? Calendar { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResourceResource? Resource { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
