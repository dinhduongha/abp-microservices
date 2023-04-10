using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class CrmLeadScoringFrequency
{
    public Guid Id { get; set; }

    public Guid? TeamId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Variable { get; set; }

    public string? Value { get; set; }

    public decimal? WonCount { get; set; }

    public decimal? LostCount { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual CrmTeam? Team { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
