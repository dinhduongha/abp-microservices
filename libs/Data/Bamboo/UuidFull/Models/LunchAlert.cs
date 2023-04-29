using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class LunchAlert
{
    public Guid Id { get; set; }

    public Guid? CronId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Mode { get; set; }

    public string? Recipients { get; set; }

    public string? NotificationMoment { get; set; }

    public string? Tz { get; set; }

    public DateOnly? Until { get; set; }

    public string? Name { get; set; }

    public string? Message { get; set; }

    public bool? Mon { get; set; }

    public bool? Tue { get; set; }

    public bool? Wed { get; set; }

    public bool? Thu { get; set; }

    public bool? Fri { get; set; }

    public bool? Sat { get; set; }

    public bool? Sun { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? NotificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrCron? Cron { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<LunchLocation> LunchLocations { get; } = new List<LunchLocation>();
}
