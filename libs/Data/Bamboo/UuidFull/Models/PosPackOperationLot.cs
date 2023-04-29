using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class PosPackOperationLot
{
    public Guid Id { get; set; }

    public Guid? PosOrderLineId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? LotName { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual PosOrderLine? PosOrderLine { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
