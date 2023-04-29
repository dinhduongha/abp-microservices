using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MrpProductionBackorder
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MrpProductionBackorderLine> MrpProductionBackorderLines { get; } = new List<MrpProductionBackorderLine>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();
}
