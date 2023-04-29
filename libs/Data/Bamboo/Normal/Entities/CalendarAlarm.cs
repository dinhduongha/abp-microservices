﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("calendar_alarm")]
public partial class CalendarAlarm
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("duration")]
    public long? Duration { get; set; }

    [Column("duration_minutes")]
    public long? DurationMinutes { get; set; }

    [Column("mail_template_id")]
    public Guid? MailTemplateId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("alarm_type")]
    public string? AlarmType { get; set; }

    [Column("interval")]
    public string? Interval { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("body")]
    public string? Body { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("sms_template_id")]
    public Guid? SmsTemplateId { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("CalendarAlarmCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MailTemplateId")]
    //[InverseProperty("CalendarAlarms")]
    public virtual MailTemplate? MailTemplate { get; set; }

    [ForeignKey("SmsTemplateId")]
    //[InverseProperty("CalendarAlarms")]
    public virtual SmsTemplate? SmsTemplate { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("CalendarAlarmWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("CalendarAlarmId")]
    [InverseProperty("CalendarAlarms")]
    [NotMapped]
    public virtual ICollection<CalendarEvent> CalendarEvents { get; } = new List<CalendarEvent>();
}
