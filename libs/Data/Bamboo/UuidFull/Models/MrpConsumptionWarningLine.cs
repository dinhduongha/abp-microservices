using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MrpConsumptionWarningLine
{
    public Guid Id { get; set; }

    public Guid? MrpConsumptionWarningId { get; set; }

    public Guid? MrpProductionId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? ProductConsumedQtyUom { get; set; }

    public double? ProductExpectedQtyUom { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpConsumptionWarning? MrpConsumptionWarning { get; set; }

    public virtual MrpProduction? MrpProduction { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
