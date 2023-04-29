using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockImmediateTransferLine
{
    public Guid Id { get; set; }

    public Guid? ImmediateTransferId { get; set; }

    public Guid? PickingId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public bool? ToImmediate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockImmediateTransfer? ImmediateTransfer { get; set; }

    public virtual StockPicking? Picking { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
