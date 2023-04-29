using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_location")]
[Index("Barcode", "CompanyId", Name = "stock_location_barcode_company_uniq", IsUnique = true)]
[Index("CompanyId", Name = "stock_location_company_id_index")]
[Index("LocationId", Name = "stock_location_location_id_index")]
[Index("ParentPath", Name = "stock_location_parent_path_index")]
[Index("Usage", Name = "stock_location_usage_index")]
public partial class StockLocation
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("location_id")]
    public Guid? LocationId { get; set; }

    [Column("posx")]
    public long? Posx { get; set; }

    [Column("posy")]
    public long? Posy { get; set; }

    [Column("posz")]
    public long? Posz { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("removal_strategy_id")]
    public Guid? RemovalStrategyId { get; set; }

    [Column("cyclic_inventory_frequency")]
    public long? CyclicInventoryFrequency { get; set; }

    [Column("warehouse_id")]
    public Guid? WarehouseId { get; set; }

    [Column("storage_category_id")]
    public long? StorageCategoryId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("complete_name")]
    public string? CompleteName { get; set; }

    [Column("usage")]
    public string? Usage { get; set; }

    [Column("parent_path")]
    public string? ParentPath { get; set; }

    [Column("barcode")]
    public string? Barcode { get; set; }

    [Column("last_inventory_date")]
    public DateOnly? LastInventoryDate { get; set; }

    [Column("next_inventory_date")]
    public DateOnly? NextInventoryDate { get; set; }

    [Column("comment")]
    public string? Comment { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("scrap_location")]
    public bool? ScrapLocation { get; set; }

    [Column("return_location")]
    public bool? ReturnLocation { get; set; }

    [Column("replenish_location")]
    public bool? ReplenishLocation { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("valuation_in_account_id")]
    public Guid? ValuationInAccountId { get; set; }

    [Column("valuation_out_account_id")]
    public Guid? ValuationOutAccountId { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("StockLocations")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockLocationCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Location")]
    public virtual ICollection<StockLocation> InverseLocation { get; } = new List<StockLocation>();

    [ForeignKey("LocationId")]
    [InverseProperty("InverseLocation")]
    public virtual StockLocation? Location { get; set; }

    [InverseProperty("LocationDest")]
    public virtual ICollection<MrpProduction> MrpProductionLocationDests { get; } = new List<MrpProduction>();

    [InverseProperty("LocationSrc")]
    public virtual ICollection<MrpProduction> MrpProductionLocationSrcs { get; } = new List<MrpProduction>();

    [InverseProperty("ProductionLocation")]
    public virtual ICollection<MrpProduction> MrpProductionProductionLocations { get; } = new List<MrpProduction>();

    [InverseProperty("LocationDest")]
    public virtual ICollection<MrpUnbuild> MrpUnbuildLocationDests { get; } = new List<MrpUnbuild>();

    [InverseProperty("Location")]
    public virtual ICollection<MrpUnbuild> MrpUnbuildLocations { get; } = new List<MrpUnbuild>();

    [ForeignKey("RemovalStrategyId")]
    [InverseProperty("StockLocations")]
    public virtual ProductRemoval? RemovalStrategy { get; set; }

    [InverseProperty("LocationDest")]
    public virtual ICollection<RepairLine> RepairLineLocationDests { get; } = new List<RepairLine>();

    [InverseProperty("Location")]
    public virtual ICollection<RepairLine> RepairLineLocations { get; } = new List<RepairLine>();

    [InverseProperty("Location")]
    public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    [InverseProperty("InternalTransitLocation")]
    public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    [InverseProperty("LocationDest")]
    public virtual ICollection<StockMoveLine> StockMoveLineLocationDests { get; } = new List<StockMoveLine>();

    [InverseProperty("Location")]
    public virtual ICollection<StockMoveLine> StockMoveLineLocations { get; } = new List<StockMoveLine>();

    [InverseProperty("LocationDest")]
    public virtual ICollection<StockMove> StockMoveLocationDests { get; } = new List<StockMove>();

    [InverseProperty("Location")]
    public virtual ICollection<StockMove> StockMoveLocations { get; } = new List<StockMove>();

    [InverseProperty("LocationDest")]
    public virtual ICollection<StockPackageDestination> StockPackageDestinations { get; } = new List<StockPackageDestination>();

    [InverseProperty("LocationDest")]
    public virtual ICollection<StockPackageLevel> StockPackageLevels { get; } = new List<StockPackageLevel>();

    [InverseProperty("LocationDest")]
    public virtual ICollection<StockPicking> StockPickingLocationDests { get; } = new List<StockPicking>();

    [InverseProperty("Location")]
    public virtual ICollection<StockPicking> StockPickingLocations { get; } = new List<StockPicking>();

    [InverseProperty("DefaultLocationDest")]
    public virtual ICollection<StockPickingType> StockPickingTypeDefaultLocationDests { get; } = new List<StockPickingType>();

    [InverseProperty("DefaultLocationSrc")]
    public virtual ICollection<StockPickingType> StockPickingTypeDefaultLocationSrcs { get; } = new List<StockPickingType>();

    [InverseProperty("LocationIn")]
    public virtual ICollection<StockPutawayRule> StockPutawayRuleLocationIns { get; } = new List<StockPutawayRule>();

    [InverseProperty("LocationOut")]
    public virtual ICollection<StockPutawayRule> StockPutawayRuleLocationOuts { get; } = new List<StockPutawayRule>();

    [InverseProperty("Location")]
    public virtual ICollection<StockQuantPackage> StockQuantPackages { get; } = new List<StockQuantPackage>();

    [InverseProperty("Location")]
    public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();

    [InverseProperty("Location")]
    public virtual ICollection<StockReturnPicking> StockReturnPickingLocations { get; } = new List<StockReturnPicking>();

    [InverseProperty("OriginalLocation")]
    public virtual ICollection<StockReturnPicking> StockReturnPickingOriginalLocations { get; } = new List<StockReturnPicking>();

    [InverseProperty("ParentLocation")]
    public virtual ICollection<StockReturnPicking> StockReturnPickingParentLocations { get; } = new List<StockReturnPicking>();

    [InverseProperty("LocationDest")]
    public virtual ICollection<StockRule> StockRuleLocationDests { get; } = new List<StockRule>();

    [InverseProperty("LocationSrc")]
    public virtual ICollection<StockRule> StockRuleLocationSrcs { get; } = new List<StockRule>();

    [InverseProperty("Location")]
    public virtual ICollection<StockScrap> StockScrapLocations { get; } = new List<StockScrap>();

    [InverseProperty("ScrapLocation")]
    public virtual ICollection<StockScrap> StockScrapScrapLocations { get; } = new List<StockScrap>();

    [InverseProperty("LotStock")]
    public virtual ICollection<StockWarehouse> StockWarehouseLotStocks { get; } = new List<StockWarehouse>();

    [InverseProperty("Location")]
    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; } = new List<StockWarehouseOrderpoint>();

    [InverseProperty("PbmLoc")]
    public virtual ICollection<StockWarehouse> StockWarehousePbmLocs { get; } = new List<StockWarehouse>();

    [InverseProperty("SamLoc")]
    public virtual ICollection<StockWarehouse> StockWarehouseSamLocs { get; } = new List<StockWarehouse>();

    [InverseProperty("ViewLocation")]
    public virtual ICollection<StockWarehouse> StockWarehouseViewLocations { get; } = new List<StockWarehouse>();

    [InverseProperty("WhInputStockLoc")]
    public virtual ICollection<StockWarehouse> StockWarehouseWhInputStockLocs { get; } = new List<StockWarehouse>();

    [InverseProperty("WhOutputStockLoc")]
    public virtual ICollection<StockWarehouse> StockWarehouseWhOutputStockLocs { get; } = new List<StockWarehouse>();

    [InverseProperty("WhPackStockLoc")]
    public virtual ICollection<StockWarehouse> StockWarehouseWhPackStockLocs { get; } = new List<StockWarehouse>();

    [InverseProperty("WhQcStockLoc")]
    public virtual ICollection<StockWarehouse> StockWarehouseWhQcStockLocs { get; } = new List<StockWarehouse>();

    [InverseProperty("Location")]
    public virtual ICollection<StockWarnInsufficientQtyRepair> StockWarnInsufficientQtyRepairs { get; } = new List<StockWarnInsufficientQtyRepair>();

    [InverseProperty("Location")]
    public virtual ICollection<StockWarnInsufficientQtyScrap> StockWarnInsufficientQtyScraps { get; } = new List<StockWarnInsufficientQtyScrap>();

    [InverseProperty("Location")]
    public virtual ICollection<StockWarnInsufficientQtyUnbuild> StockWarnInsufficientQtyUnbuilds { get; } = new List<StockWarnInsufficientQtyUnbuild>();

    [ForeignKey("ValuationInAccountId")]
    [InverseProperty("StockLocationValuationInAccounts")]
    public virtual AccountAccount? ValuationInAccount { get; set; }

    [ForeignKey("ValuationOutAccountId")]
    [InverseProperty("StockLocationValuationOutAccounts")]
    public virtual AccountAccount? ValuationOutAccount { get; set; }

    [ForeignKey("WarehouseId")]
    [InverseProperty("StockLocations")]
    public virtual StockWarehouse? Warehouse { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("StockLocationWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
