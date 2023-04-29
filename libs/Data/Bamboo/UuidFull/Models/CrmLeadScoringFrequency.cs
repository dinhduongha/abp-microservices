using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class CrmLeadScoringFrequency
{
    public Guid Id { get; set; }

    public Guid? TeamId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Variable { get; set; }

    public string? Value { get; set; }

    public decimal? WonCount { get; set; }

    public decimal? LostCount { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual CrmTeam? Team { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
