using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockImmediateTransferLine
{
    public Guid Id { get; set; }

    public Guid? ImmediateTransferId { get; set; }

    public Guid? PickingId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? ToImmediate { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockImmediateTransfer? ImmediateTransfer { get; set; }

    public virtual StockPicking? Picking { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
