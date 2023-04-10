using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProcurementGroup
{
    public Guid Id { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? MoveType { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? PosOrderId { get; set; }

    public Guid? SaleId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();

    public virtual ResPartner? Partner { get; set; }

    public virtual PosOrder? PosOrder { get; set; }

    //public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    //public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

    public virtual SaleOrder? Sale { get; set; }

    //public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    //public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    //public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();

    //public virtual ICollection<StockRule> StockRules { get; } = new List<StockRule>();

    //public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; } = new List<StockWarehouseOrderpoint>();

    public virtual ResUser? WriteU { get; set; }
}
