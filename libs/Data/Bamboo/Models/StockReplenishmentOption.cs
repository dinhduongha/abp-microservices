using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockReplenishmentOption
{
    public Guid Id { get; set; }

    public Guid? RouteId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? ReplenishmentInfoId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual StockReplenishmentInfo? ReplenishmentInfo { get; set; }

    public virtual StockRoute? Route { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
