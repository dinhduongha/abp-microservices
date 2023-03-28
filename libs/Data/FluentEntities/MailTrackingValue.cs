using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailTrackingValue
{
    public Guid Id { get; set; }

    public Guid? Field { get; set; }

    public long? OldValueInteger { get; set; }

    public long? NewValueInteger { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? MailMessageId { get; set; }

    public long? TrackingSequence { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? FieldDesc { get; set; }

    public string? FieldType { get; set; }

    public string? OldValueChar { get; set; }

    public string? NewValueChar { get; set; }

    public string? OldValueText { get; set; }

    public string? NewValueText { get; set; }

    public DateTime? OldValueDatetime { get; set; }

    public DateTime? NewValueDatetime { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? OldValueFloat { get; set; }

    public double? OldValueMonetary { get; set; }

    public double? NewValueFloat { get; set; }

    public double? NewValueMonetary { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual IrModelField? FieldNavigation { get; set; }

    public virtual MailMessage? MailMessage { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
