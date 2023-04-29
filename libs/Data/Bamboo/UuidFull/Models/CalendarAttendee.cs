using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class CalendarAttendee
{
    public Guid Id { get; set; }

    public Guid? EventId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? CommonName { get; set; }

    public string? AccessToken { get; set; }

    public string? State { get; set; }

    public string? Availability { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual CalendarEvent? Event { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
