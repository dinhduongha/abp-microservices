using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockWarnInsufficientQtyRepair
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? LocationId { get; set; }

    public Guid? RepairId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? ProductUomName { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? Quantity { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? Location { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual RepairOrder? Repair { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
