using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockReplenishmentInfo
{
    public Guid Id { get; set; }

    public Guid? OrderpointId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockWarehouseOrderpoint? Orderpoint { get; set; }

    //public virtual ICollection<StockReplenishmentOption> StockReplenishmentOptions { get; } = new List<StockReplenishmentOption>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; } = new List<ProductSupplierinfo>();
}
