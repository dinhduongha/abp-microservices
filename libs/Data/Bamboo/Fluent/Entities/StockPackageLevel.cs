using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockPackageLevel
{
    public Guid Id { get; set; }

    public Guid? PackageId { get; set; }

    public Guid? PickingId { get; set; }

    public Guid? LocationDestId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? LocationDest { get; set; }

    public virtual StockQuantPackage? Package { get; set; }

    public virtual StockPicking? Picking { get; set; }

    //public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();

    //public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    public virtual ResUser? WriteU { get; set; }
}
