using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockReturnPicking
{
    public Guid Id { get; set; }

    public Guid? PickingId { get; set; }

    public Guid? OriginalLocationId { get; set; }

    public Guid? ParentLocationId { get; set; }

    public Guid? LocationId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? MoveDestExists { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? Location { get; set; }

    public virtual StockLocation? OriginalLocation { get; set; }

    public virtual StockLocation? ParentLocation { get; set; }

    public virtual StockPicking? Picking { get; set; }

    //public virtual ICollection<StockReturnPickingLine> StockReturnPickingLines { get; } = new List<StockReturnPickingLine>();

    public virtual ResUser? WriteU { get; set; }
}
