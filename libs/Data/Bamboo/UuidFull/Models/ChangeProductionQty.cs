using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ChangeProductionQty
{
    public Guid Id { get; set; }

    public Guid? MoId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public decimal? ProductQty { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpProduction? Mo { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
