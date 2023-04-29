using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class CalendarAlarm
{
    public Guid Id { get; set; }

    public long? Duration { get; set; }

    public long? DurationMinutes { get; set; }

    public Guid? MailTemplateId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? AlarmType { get; set; }

    public string? Interval { get; set; }

    public string? Name { get; set; }

    public string? Body { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? SmsTemplateId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailTemplate? MailTemplate { get; set; }

    public virtual SmsTemplate? SmsTemplate { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<CalendarEvent> CalendarEvents { get; } = new List<CalendarEvent>();
}
