using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProductPackaging
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Barcode { get; set; }

    public decimal? Qty { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public bool? Sales { get; set; }

    public long? PackageTypeId { get; set; }

    public bool? Purchase { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockPackageType? PackageType { get; set; }

    public virtual ProductProduct? Product { get; set; }

    //public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    //public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();

    //public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<StockRoute> Routes { get; } = new List<StockRoute>();
}
