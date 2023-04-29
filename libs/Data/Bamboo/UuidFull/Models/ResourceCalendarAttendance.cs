using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ResourceCalendarAttendance
{
    public Guid Id { get; set; }

    public Guid? CalendarId { get; set; }

    public Guid? ResourceId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Dayofweek { get; set; }

    public string? DayPeriod { get; set; }

    public string? WeekType { get; set; }

    public string? DisplayType { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateOnly? DateTo { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? HourFrom { get; set; }

    public double? HourTo { get; set; }

    public virtual ResourceCalendar? Calendar { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResourceResource? Resource { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
