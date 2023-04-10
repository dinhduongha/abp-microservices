using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockBackorderConfirmationLine
{
    public Guid Id { get; set; }

    public Guid? BackorderConfirmationId { get; set; }

    public Guid? PickingId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? ToBackorder { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual StockBackorderConfirmation? BackorderConfirmation { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockPicking? Picking { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
