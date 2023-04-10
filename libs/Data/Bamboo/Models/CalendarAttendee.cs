using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class CalendarAttendee
{
    public Guid Id { get; set; }

    public Guid? EventId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? CommonName { get; set; }

    public string? AccessToken { get; set; }

    public string? State { get; set; }

    public string? Availability { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual CalendarEvent? Event { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
