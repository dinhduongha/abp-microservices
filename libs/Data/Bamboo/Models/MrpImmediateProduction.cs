using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MrpImmediateProduction
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<MrpImmediateProductionLine> MrpImmediateProductionLines { get; } = new List<MrpImmediateProductionLine>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();
}
