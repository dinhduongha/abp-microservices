using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class CalendarRecurrence
{
    public Guid Id { get; set; }

    public Guid? BaseEventId { get; set; }

    public long? Interval { get; set; }

    public long? Count { get; set; }

    public long? Day { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? EventTz { get; set; }

    public string? Rrule { get; set; }

    public string? RruleType { get; set; }

    public string? EndType { get; set; }

    public string? MonthBy { get; set; }

    public string? Weekday { get; set; }

    public string? Byday { get; set; }

    public DateOnly? Until { get; set; }

    public bool? Mon { get; set; }

    public bool? Tue { get; set; }

    public bool? Wed { get; set; }

    public bool? Thu { get; set; }

    public bool? Fri { get; set; }

    public bool? Sat { get; set; }

    public bool? Sun { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual CalendarEvent? BaseEvent { get; set; }

    //public virtual ICollection<CalendarEvent> CalendarEvents { get; } = new List<CalendarEvent>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
