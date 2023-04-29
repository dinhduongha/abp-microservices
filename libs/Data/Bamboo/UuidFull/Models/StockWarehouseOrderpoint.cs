using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockWarehouseOrderpoint
{
    public Guid Id { get; set; }

    public Guid? WarehouseId { get; set; }

    public Guid? LocationId { get; set; }

    public Guid? ProductId { get; set; }

    public long? ProductCategoryId { get; set; }

    public Guid? GroupId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? RouteId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Trigger { get; set; }

    public DateOnly? SnoozedUntil { get; set; }

    public decimal? ProductMinQty { get; set; }

    public decimal? ProductMaxQty { get; set; }

    public decimal? QtyMultiple { get; set; }

    public decimal? QtyToOrder { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? SupplierId { get; set; }

    public Guid? VendorId { get; set; }

    public double? PurchaseVisibilityDays { get; set; }

    public Guid? BomId { get; set; }

    public double? ManufacturingVisibilityDays { get; set; }

    public virtual MrpBom? Bom { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProcurementGroup? Group { get; set; }

    public virtual StockLocation? Location { get; set; }

    public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();

    public virtual ProductProduct? Product { get; set; }

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    public virtual StockRoute? Route { get; set; }

    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    public virtual ICollection<StockReplenishmentInfo> StockReplenishmentInfos { get; } = new List<StockReplenishmentInfo>();

    public virtual ProductSupplierinfo? Supplier { get; set; }

    public virtual ResPartner? Vendor { get; set; }

    public virtual StockWarehouse? Warehouse { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockOrderpointSnooze> StockOrderpointSnoozes { get; } = new List<StockOrderpointSnooze>();
}
