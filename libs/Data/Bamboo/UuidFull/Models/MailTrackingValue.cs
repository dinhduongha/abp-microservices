﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MailTrackingValue
{
    public Guid Id { get; set; }

    public Guid? Field { get; set; }

    public long? OldValueInteger { get; set; }

    public long? NewValueInteger { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? MailMessageId { get; set; }

    public long? TrackingSequence { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? FieldDesc { get; set; }

    public string? FieldType { get; set; }

    public string? OldValueChar { get; set; }

    public string? NewValueChar { get; set; }

    public string? OldValueText { get; set; }

    public string? NewValueText { get; set; }

    public DateTime? OldValueDatetime { get; set; }

    public DateTime? NewValueDatetime { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? OldValueFloat { get; set; }

    public double? OldValueMonetary { get; set; }

    public double? NewValueFloat { get; set; }

    public double? NewValueMonetary { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModelField? FieldNavigation { get; set; }

    public virtual MailMessage? MailMessage { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
