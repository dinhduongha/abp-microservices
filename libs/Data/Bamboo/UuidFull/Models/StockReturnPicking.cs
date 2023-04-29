using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockReturnPicking
{
    public Guid Id { get; set; }

    public Guid? PickingId { get; set; }

    public Guid? OriginalLocationId { get; set; }

    public Guid? ParentLocationId { get; set; }

    public Guid? LocationId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public bool? MoveDestExists { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? Location { get; set; }

    public virtual StockLocation? OriginalLocation { get; set; }

    public virtual StockLocation? ParentLocation { get; set; }

    public virtual StockPicking? Picking { get; set; }

    public virtual ICollection<StockReturnPickingLine> StockReturnPickingLines { get; } = new List<StockReturnPickingLine>();

    public virtual ResUser? WriteU { get; set; }
}
