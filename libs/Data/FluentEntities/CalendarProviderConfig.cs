using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class CalendarProviderConfig
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? ExternalCalendarProvider { get; set; }

    public string? CalClientId { get; set; }

    public string? CalClientSecret { get; set; }

    public string? MicrosoftOutlookClientIdentifier { get; set; }

    public string? MicrosoftOutlookClientSecret { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
