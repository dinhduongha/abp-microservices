using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class SpreadsheetDashboard
{
    public Guid Id { get; set; }

    public long? DashboardGroupId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual SpreadsheetDashboardGroup? DashboardGroup { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ResGroup> ResGroups { get; } = new List<ResGroup>();
}
