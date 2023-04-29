﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MailMessageSchedule
{
    public Guid Id { get; set; }

    public Guid? MailMessageId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? NotificationParameters { get; set; }

    public DateTime? ScheduledDatetime { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailMessage? MailMessage { get; set; }

    public virtual ResUser? WriteU { get; set; }
}