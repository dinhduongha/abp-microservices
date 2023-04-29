using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class SpreadsheetDashboard
{
    public Guid Id { get; set; }

    public long? DashboardGroupId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResGroup> ResGroups { get; } = new List<ResGroup>();
}
