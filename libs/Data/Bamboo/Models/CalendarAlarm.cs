using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class CalendarAlarm
{
    public Guid Id { get; set; }

    public long? Duration { get; set; }

    public long? DurationMinutes { get; set; }

    public Guid? MailTemplateId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? AlarmType { get; set; }

    public string? Interval { get; set; }

    public string? Name { get; set; }

    public string? Body { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? SmsTemplateId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailTemplate? MailTemplate { get; set; }

    public virtual SmsTemplate? SmsTemplate { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<CalendarEvent> CalendarEvents { get; } = new List<CalendarEvent>();
}
