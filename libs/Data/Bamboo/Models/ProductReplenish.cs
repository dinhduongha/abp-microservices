using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProductReplenish
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? ProductTmplId { get; set; }

    public Guid? ProductUomId { get; set; }

    public Guid? WarehouseId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? ProductHasVariants { get; set; }

    public DateTime? DatePlanned { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? Quantity { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ProductTemplate? ProductTmpl { get; set; }

    public virtual UomUom? ProductUom { get; set; }

    public virtual StockWarehouse? Warehouse { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<StockRoute> StockRoutes { get; } = new List<StockRoute>();
}
