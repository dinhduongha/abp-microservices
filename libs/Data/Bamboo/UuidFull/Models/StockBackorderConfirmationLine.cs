using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockBackorderConfirmationLine
{
    public Guid Id { get; set; }

    public Guid? BackorderConfirmationId { get; set; }

    public Guid? PickingId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public bool? ToBackorder { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual StockBackorderConfirmation? BackorderConfirmation { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockPicking? Picking { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
