using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class CalendarProviderConfig
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? ExternalCalendarProvider { get; set; }

    public string? CalClientId { get; set; }

    public string? CalClientSecret { get; set; }

    public string? MicrosoftOutlookClientIdentifier { get; set; }

    public string? MicrosoftOutlookClientSecret { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
