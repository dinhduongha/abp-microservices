using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockPackageDestination
{
    public Guid Id { get; set; }

    public Guid? PickingId { get; set; }

    public Guid? LocationDestId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? LocationDest { get; set; }

    public virtual StockPicking? Picking { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
