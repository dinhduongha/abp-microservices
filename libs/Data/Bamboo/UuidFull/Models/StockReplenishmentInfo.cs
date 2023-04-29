using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockReplenishmentInfo
{
    public Guid Id { get; set; }

    public Guid? OrderpointId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockWarehouseOrderpoint? Orderpoint { get; set; }

    public virtual ICollection<StockReplenishmentOption> StockReplenishmentOptions { get; } = new List<StockReplenishmentOption>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; } = new List<ProductSupplierinfo>();
}
