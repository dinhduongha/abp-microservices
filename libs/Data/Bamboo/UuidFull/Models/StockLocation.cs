using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockLocation
{
    public Guid Id { get; set; }

    public Guid? LocationId { get; set; }

    public long? Posx { get; set; }

    public long? Posy { get; set; }

    public long? Posz { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? RemovalStrategyId { get; set; }

    public long? CyclicInventoryFrequency { get; set; }

    public Guid? WarehouseId { get; set; }

    public long? StorageCategoryId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? CompleteName { get; set; }

    public string? Usage { get; set; }

    public string? ParentPath { get; set; }

    public string? Barcode { get; set; }

    public DateOnly? LastInventoryDate { get; set; }

    public DateOnly? NextInventoryDate { get; set; }

    public string? Comment { get; set; }

    public bool? Active { get; set; }

    public bool? ScrapLocation { get; set; }

    public bool? ReturnLocation { get; set; }

    public bool? ReplenishLocation { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? ValuationInAccountId { get; set; }

    public Guid? ValuationOutAccountId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<StockLocation> InverseLocation { get; } = new List<StockLocation>();

    public virtual StockLocation? Location { get; set; }

    public virtual ICollection<MrpProduction> MrpProductionLocationDests { get; } = new List<MrpProduction>();

    public virtual ICollection<MrpProduction> MrpProductionLocationSrcs { get; } = new List<MrpProduction>();

    public virtual ICollection<MrpProduction> MrpProductionProductionLocations { get; } = new List<MrpProduction>();

    public virtual ICollection<MrpUnbuild> MrpUnbuildLocationDests { get; } = new List<MrpUnbuild>();

    public virtual ICollection<MrpUnbuild> MrpUnbuildLocations { get; } = new List<MrpUnbuild>();

    public virtual ProductRemoval? RemovalStrategy { get; set; }

    public virtual ICollection<RepairLine> RepairLineLocationDests { get; } = new List<RepairLine>();

    public virtual ICollection<RepairLine> RepairLineLocations { get; } = new List<RepairLine>();

    public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    public virtual ICollection<StockMoveLine> StockMoveLineLocationDests { get; } = new List<StockMoveLine>();

    public virtual ICollection<StockMoveLine> StockMoveLineLocations { get; } = new List<StockMoveLine>();

    public virtual ICollection<StockMove> StockMoveLocationDests { get; } = new List<StockMove>();

    public virtual ICollection<StockMove> StockMoveLocations { get; } = new List<StockMove>();

    public virtual ICollection<StockPackageDestination> StockPackageDestinations { get; } = new List<StockPackageDestination>();

    public virtual ICollection<StockPackageLevel> StockPackageLevels { get; } = new List<StockPackageLevel>();

    public virtual ICollection<StockPicking> StockPickingLocationDests { get; } = new List<StockPicking>();

    public virtual ICollection<StockPicking> StockPickingLocations { get; } = new List<StockPicking>();

    public virtual ICollection<StockPickingType> StockPickingTypeDefaultLocationDests { get; } = new List<StockPickingType>();

    public virtual ICollection<StockPickingType> StockPickingTypeDefaultLocationSrcs { get; } = new List<StockPickingType>();

    public virtual ICollection<StockPutawayRule> StockPutawayRuleLocationIns { get; } = new List<StockPutawayRule>();

    public virtual ICollection<StockPutawayRule> StockPutawayRuleLocationOuts { get; } = new List<StockPutawayRule>();

    public virtual ICollection<StockQuantPackage> StockQuantPackages { get; } = new List<StockQuantPackage>();

    public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();

    public virtual ICollection<StockReturnPicking> StockReturnPickingLocations { get; } = new List<StockReturnPicking>();

    public virtual ICollection<StockReturnPicking> StockReturnPickingOriginalLocations { get; } = new List<StockReturnPicking>();

    public virtual ICollection<StockReturnPicking> StockReturnPickingParentLocations { get; } = new List<StockReturnPicking>();

    public virtual ICollection<StockRule> StockRuleLocationDests { get; } = new List<StockRule>();

    public virtual ICollection<StockRule> StockRuleLocationSrcs { get; } = new List<StockRule>();

    public virtual ICollection<StockScrap> StockScrapLocations { get; } = new List<StockScrap>();

    public virtual ICollection<StockScrap> StockScrapScrapLocations { get; } = new List<StockScrap>();

    public virtual ICollection<StockWarehouse> StockWarehouseLotStocks { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; } = new List<StockWarehouseOrderpoint>();

    public virtual ICollection<StockWarehouse> StockWarehousePbmLocs { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseSamLocs { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseViewLocations { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseWhInputStockLocs { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseWhOutputStockLocs { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseWhPackStockLocs { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseWhQcStockLocs { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarnInsufficientQtyRepair> StockWarnInsufficientQtyRepairs { get; } = new List<StockWarnInsufficientQtyRepair>();

    public virtual ICollection<StockWarnInsufficientQtyScrap> StockWarnInsufficientQtyScraps { get; } = new List<StockWarnInsufficientQtyScrap>();

    public virtual ICollection<StockWarnInsufficientQtyUnbuild> StockWarnInsufficientQtyUnbuilds { get; } = new List<StockWarnInsufficientQtyUnbuild>();

    public virtual AccountAccount? ValuationInAccount { get; set; }

    public virtual AccountAccount? ValuationOutAccount { get; set; }

    public virtual StockWarehouse? Warehouse { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
