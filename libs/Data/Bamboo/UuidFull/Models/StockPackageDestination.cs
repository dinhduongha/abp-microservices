using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockPackageDestination
{
    public Guid Id { get; set; }

    public Guid? PickingId { get; set; }

    public Guid? LocationDestId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? LocationDest { get; set; }

    public virtual StockPicking? Picking { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
