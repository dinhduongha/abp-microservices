using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockRulesReport
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? ProductTmplId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public bool? ProductHasVariants { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ProductTemplate? ProductTmpl { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockRoute> StockRoutes { get; } = new List<StockRoute>();

    public virtual ICollection<StockWarehouse> StockWarehouses { get; } = new List<StockWarehouse>();
}
