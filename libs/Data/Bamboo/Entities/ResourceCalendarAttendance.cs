using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("resource_calendar_attendance")]
[Index("Dayofweek", Name = "resource_calendar_attendance_dayofweek_index")]
[Index("HourFrom", Name = "resource_calendar_attendance_hour_from_index")]
public partial class ResourceCalendarAttendance
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("calendar_id")]
    public Guid? CalendarId { get; set; }

    [Column("resource_id")]
    public Guid? ResourceId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("dayofweek")]
    public string? Dayofweek { get; set; }

    [Column("day_period")]
    public string? DayPeriod { get; set; }

    [Column("week_type")]
    public string? WeekType { get; set; }

    [Column("display_type")]
    public string? DisplayType { get; set; }

    [Column("date_from")]
    public DateOnly? DateFrom { get; set; }

    [Column("date_to")]
    public DateOnly? DateTo { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("hour_from")]
    public double? HourFrom { get; set; }

    [Column("hour_to")]
    public double? HourTo { get; set; }

    [ForeignKey("CalendarId")]
    //[InverseProperty("ResourceCalendarAttendances")]
    public virtual ResourceCalendar? Calendar { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("ResourceCalendarAttendanceCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ResourceId")]
    //[InverseProperty("ResourceCalendarAttendances")]
    public virtual ResourceResource? Resource { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("ResourceCalendarAttendanceWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
