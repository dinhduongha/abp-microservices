using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class CrmStage
{
    public long Id { get; set; }

    public long Sequence { get; set; }

    public Guid? TeamId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Requirements { get; set; }

    public bool? IsWon { get; set; }

    public bool? Fold { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    public virtual CrmTeam? Team { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
