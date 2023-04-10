using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockWarehouse
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? ViewLocationId { get; set; }

    public Guid? LotStockId { get; set; }

    public Guid? WhInputStockLocId { get; set; }

    public Guid? WhQcStockLocId { get; set; }

    public Guid? WhOutputStockLocId { get; set; }

    public Guid? WhPackStockLocId { get; set; }

    public Guid? MtoPullId { get; set; }

    public Guid? PickTypeId { get; set; }

    public Guid? PackTypeId { get; set; }

    public Guid? OutTypeId { get; set; }

    public Guid? InTypeId { get; set; }

    public Guid? IntTypeId { get; set; }

    public Guid? ReturnTypeId { get; set; }

    public Guid? CrossdockRouteId { get; set; }

    public Guid? ReceptionRouteId { get; set; }

    public Guid? DeliveryRouteId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? ReceptionSteps { get; set; }

    public string? DeliverySteps { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? PosTypeId { get; set; }

    public Guid? BuyPullId { get; set; }

    public bool? BuyToResupply { get; set; }

    public Guid? ManufacturePullId { get; set; }

    public Guid? ManufactureMtoPullId { get; set; }

    public Guid? PbmMtoPullId { get; set; }

    public Guid? SamRuleId { get; set; }

    public Guid? ManuTypeId { get; set; }

    public Guid? PbmTypeId { get; set; }

    public Guid? SamTypeId { get; set; }

    public Guid? PbmRouteId { get; set; }

    public Guid? PbmLocId { get; set; }

    public Guid? SamLocId { get; set; }

    public string? ManufactureSteps { get; set; }

    public bool? ManufactureToResupply { get; set; }

    public virtual StockRule? BuyPull { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockRoute? CrossdockRoute { get; set; }

    public virtual StockRoute? DeliveryRoute { get; set; }

    public virtual StockPickingType? InType { get; set; }

    public virtual StockPickingType? IntType { get; set; }

    public virtual StockLocation? LotStock { get; set; }

    public virtual StockPickingType? ManuType { get; set; }

    public virtual StockRule? ManufactureMtoPull { get; set; }

    public virtual StockRule? ManufacturePull { get; set; }

    public virtual StockRule? MtoPull { get; set; }

    public virtual StockPickingType? OutType { get; set; }

    public virtual StockPickingType? PackType { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual StockLocation? PbmLoc { get; set; }

    public virtual StockRule? PbmMtoPull { get; set; }

    public virtual StockRoute? PbmRoute { get; set; }

    public virtual StockPickingType? PbmType { get; set; }

    public virtual StockPickingType? PickType { get; set; }

    //public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();

    public virtual StockPickingType? PosType { get; set; }

    //public virtual ICollection<ProductReplenish> ProductReplenishes { get; } = new List<ProductReplenish>();

    public virtual StockRoute? ReceptionRoute { get; set; }

    public virtual StockPickingType? ReturnType { get; set; }

    //public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    public virtual StockLocation? SamLoc { get; set; }

    public virtual StockRule? SamRule { get; set; }

    public virtual StockPickingType? SamType { get; set; }

    //public virtual ICollection<StockLocation> StockLocations { get; } = new List<StockLocation>();

    //public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    //public virtual ICollection<StockPickingType> StockPickingTypes { get; } = new List<StockPickingType>();

    //public virtual ICollection<StockRoute> StockRouteSuppliedWhs { get; } = new List<StockRoute>();

    //public virtual ICollection<StockRoute> StockRouteSupplierWhs { get; } = new List<StockRoute>();

    //public virtual ICollection<StockRule> StockRulePropagateWarehouses { get; } = new List<StockRule>();

    //public virtual ICollection<StockRule> StockRuleWarehouses { get; } = new List<StockRule>();

    //public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; } = new List<StockWarehouseOrderpoint>();

    public virtual StockLocation? ViewLocation { get; set; }

    //public virtual ICollection<Website> Websites { get; } = new List<Website>();

    public virtual StockLocation? WhInputStockLoc { get; set; }

    public virtual StockLocation? WhOutputStockLoc { get; set; }

    public virtual StockLocation? WhPackStockLoc { get; set; }

    public virtual StockLocation? WhQcStockLoc { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<StockRoute> Routes { get; } = new List<StockRoute>();

    //public virtual ICollection<StockRulesReport> StockRulesReports { get; } = new List<StockRulesReport>();

    //public virtual ICollection<StockWarehouse> SuppliedWhs { get; } = new List<StockWarehouse>();

    //public virtual ICollection<StockWarehouse> SupplierWhs { get; } = new List<StockWarehouse>();
}
