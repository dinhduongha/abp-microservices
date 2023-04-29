using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("lunch_alert")]
public partial class LunchAlert
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("cron_id")]
    public Guid? CronId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("mode")]
    public string? Mode { get; set; }

    [Column("recipients")]
    public string? Recipients { get; set; }

    [Column("notification_moment")]
    public string? NotificationMoment { get; set; }

    [Column("tz")]
    public string? Tz { get; set; }

    [Column("until")]
    public DateOnly? Until { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("message", TypeName = "jsonb")]
    public string? Message { get; set; }

    [Column("mon")]
    public bool? Mon { get; set; }

    [Column("tue")]
    public bool? Tue { get; set; }

    [Column("wed")]
    public bool? Wed { get; set; }

    [Column("thu")]
    public bool? Thu { get; set; }

    [Column("fri")]
    public bool? Fri { get; set; }

    [Column("sat")]
    public bool? Sat { get; set; }

    [Column("sun")]
    public bool? Sun { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("notification_time")]
    public double? NotificationTime { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("LunchAlertCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CronId")]
    [InverseProperty("LunchAlerts")]
    public virtual IrCron? Cron { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("LunchAlertWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("LunchAlertId")]
    [InverseProperty("LunchAlerts")]
    public virtual ICollection<LunchLocation> LunchLocations { get; } = new List<LunchLocation>();
}
