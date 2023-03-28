using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailActivity
{
    public Guid Id { get; set; }

    public Guid? ResModelId { get; set; }

    public Guid? ResId { get; set; }

    public long? ActivityTypeId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? RequestPartnerId { get; set; }

    public long? RecommendedActivityTypeId { get; set; }

    public long? PreviousActivityTypeId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? ResModel { get; set; }

    public string? ResName { get; set; }

    public string? Summary { get; set; }

    public DateOnly? DateDeadline { get; set; }

    public string? Note { get; set; }

    public bool? Automated { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? CalendarEventId { get; set; }

    public Guid? NoteId { get; set; }

    public virtual MailActivityType? ActivityType { get; set; }

    public virtual CalendarEvent? CalendarEvent { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual NoteNote? NoteNavigation { get; set; }

    public virtual MailActivityType? PreviousActivityType { get; set; }

    public virtual MailActivityType? RecommendedActivityType { get; set; }

    public virtual ResPartner? RequestPartner { get; set; }

    public virtual IrModel? ResModelNavigation { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
