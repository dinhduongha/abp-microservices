using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MeetingCategoryRel
{
    public Guid EventId { get; set; }

    public long TypeId { get; set; }

    public virtual CalendarEvent Event { get; set; } = null!;
}
