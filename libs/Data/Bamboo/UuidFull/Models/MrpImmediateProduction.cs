using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MrpImmediateProduction
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MrpImmediateProductionLine> MrpImmediateProductionLines { get; } = new List<MrpImmediateProductionLine>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();
}
