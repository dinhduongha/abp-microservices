using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MrpConsumptionWarningLine
{
    public Guid Id { get; set; }

    public Guid? MrpConsumptionWarningId { get; set; }

    public Guid? MrpProductionId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? ProductConsumedQtyUom { get; set; }

    public double? ProductExpectedQtyUom { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpConsumptionWarning? MrpConsumptionWarning { get; set; }

    public virtual MrpProduction? MrpProduction { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
