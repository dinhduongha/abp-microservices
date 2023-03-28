using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProjectTaskRecurrence
{
    public Guid Id { get; set; }

    public long? RecurrenceLeft { get; set; }

    public long? RepeatInterval { get; set; }

    public long? RepeatNumber { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? RepeatUnit { get; set; }

    public string? RepeatType { get; set; }

    public string? RepeatOnMonth { get; set; }

    public string? RepeatOnYear { get; set; }

    public string? RepeatDay { get; set; }

    public string? RepeatWeek { get; set; }

    public string? RepeatWeekday { get; set; }

    public string? RepeatMonth { get; set; }

    public DateOnly? NextRecurrenceDate { get; set; }

    public DateOnly? RepeatUntil { get; set; }

    public bool? Mon { get; set; }

    public bool? Tue { get; set; }

    public bool? Wed { get; set; }

    public bool? Thu { get; set; }

    public bool? Fri { get; set; }

    public bool? Sat { get; set; }

    public bool? Sun { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<ProjectTask> ProjectTasks { get; } = new List<ProjectTask>();

    public virtual ResUser? WriteU { get; set; }
}
