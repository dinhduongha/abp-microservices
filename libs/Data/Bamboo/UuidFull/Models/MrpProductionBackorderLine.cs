using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MrpProductionBackorderLine
{
    public Guid Id { get; set; }

    public Guid? MrpProductionBackorderId { get; set; }

    public Guid? MrpProductionId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public bool? ToBackorder { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpProduction? MrpProduction { get; set; }

    public virtual MrpProductionBackorder? MrpProductionBackorder { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
