using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MrpProductionBackorderLine
{
    public Guid Id { get; set; }

    public Guid? MrpProductionBackorderId { get; set; }

    public Guid? MrpProductionId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? ToBackorder { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpProduction? MrpProduction { get; set; }

    public virtual MrpProductionBackorder? MrpProductionBackorder { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
