﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("stock_warehouse")]
[Index("Code", "TenantId", Name = "stock_warehouse_warehouse_code_uniq", IsUnique = true)]
[Index("Name", "TenantId", Name = "stock_warehouse_warehouse_name_uniq", IsUnique = true)]
public partial class StockWarehouse: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("view_location_id")]
    public Guid? ViewLocationId { get; set; }

    [Column("lot_stock_id")]
    public Guid? LotStockId { get; set; }

    [Column("wh_input_stock_loc_id")]
    public Guid? WhInputStockLocId { get; set; }

    [Column("wh_qc_stock_loc_id")]
    public Guid? WhQcStockLocId { get; set; }

    [Column("wh_output_stock_loc_id")]
    public Guid? WhOutputStockLocId { get; set; }

    [Column("wh_pack_stock_loc_id")]
    public Guid? WhPackStockLocId { get; set; }

    [Column("mto_pull_id")]
    public Guid? MtoPullId { get; set; }

    [Column("pick_type_id")]
    public Guid? PickTypeId { get; set; }

    [Column("pack_type_id")]
    public Guid? PackTypeId { get; set; }

    [Column("out_type_id")]
    public Guid? OutTypeId { get; set; }

    [Column("in_type_id")]
    public Guid? InTypeId { get; set; }

    [Column("int_type_id")]
    public Guid? IntTypeId { get; set; }

    [Column("return_type_id")]
    public Guid? ReturnTypeId { get; set; }

    [Column("crossdock_route_id")]
    public Guid? CrossdockRouteId { get; set; }

    [Column("reception_route_id")]
    public Guid? ReceptionRouteId { get; set; }

    [Column("delivery_route_id")]
    public Guid? DeliveryRouteId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("code")]
    public string? Code { get; set; }

    [Column("reception_steps")]
    public string? ReceptionSteps { get; set; }

    [Column("delivery_steps")]
    public string? DeliverySteps { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("pos_type_id")]
    public Guid? PosTypeId { get; set; }

    [Column("buy_pull_id")]
    public Guid? BuyPullId { get; set; }

    [Column("buy_to_resupply")]
    public bool? BuyToResupply { get; set; }

    [Column("manufacture_pull_id")]
    public Guid? ManufacturePullId { get; set; }

    [Column("manufacture_mto_pull_id")]
    public Guid? ManufactureMtoPullId { get; set; }

    [Column("pbm_mto_pull_id")]
    public Guid? PbmMtoPullId { get; set; }

    [Column("sam_rule_id")]
    public Guid? SamRuleId { get; set; }

    [Column("manu_type_id")]
    public Guid? ManuTypeId { get; set; }

    [Column("pbm_type_id")]
    public Guid? PbmTypeId { get; set; }

    [Column("sam_type_id")]
    public Guid? SamTypeId { get; set; }

    [Column("pbm_route_id")]
    public Guid? PbmRouteId { get; set; }

    [Column("pbm_loc_id")]
    public Guid? PbmLocId { get; set; }

    [Column("sam_loc_id")]
    public Guid? SamLocId { get; set; }

    [Column("manufacture_steps")]
    public string? ManufactureSteps { get; set; }

    [Column("manufacture_to_resupply")]
    public bool? ManufactureToResupply { get; set; }

    [ForeignKey("BuyPullId")]
    //[InverseProperty("StockWarehouseBuyPulls")]
    public virtual StockRule? BuyPull { get; set; }

    [ForeignKey("TenantId")]
    //[InverseProperty("StockWarehouses")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("StockWarehouseCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CrossdockRouteId")]
    //[InverseProperty("StockWarehouseCrossdockRoutes")]
    public virtual StockRoute? CrossdockRoute { get; set; }

    [ForeignKey("DeliveryRouteId")]
    //[InverseProperty("StockWarehouseDeliveryRoutes")]
    public virtual StockRoute? DeliveryRoute { get; set; }

    [ForeignKey("InTypeId")]
    //[InverseProperty("StockWarehouseInTypes")]
    public virtual StockPickingType? InType { get; set; }

    [ForeignKey("IntTypeId")]
    //[InverseProperty("StockWarehouseIntTypes")]
    public virtual StockPickingType? IntType { get; set; }

    [ForeignKey("LotStockId")]
    //[InverseProperty("StockWarehouseLotStocks")]
    public virtual StockLocation? LotStock { get; set; }

    [ForeignKey("ManuTypeId")]
    //[InverseProperty("StockWarehouseManuTypes")]
    public virtual StockPickingType? ManuType { get; set; }

    [ForeignKey("ManufactureMtoPullId")]
    //[InverseProperty("StockWarehouseManufactureMtoPulls")]
    public virtual StockRule? ManufactureMtoPull { get; set; }

    [ForeignKey("ManufacturePullId")]
    //[InverseProperty("StockWarehouseManufacturePulls")]
    public virtual StockRule? ManufacturePull { get; set; }

    [ForeignKey("MtoPullId")]
    //[InverseProperty("StockWarehouseMtoPulls")]
    public virtual StockRule? MtoPull { get; set; }

    [ForeignKey("OutTypeId")]
    //[InverseProperty("StockWarehouseOutTypes")]
    public virtual StockPickingType? OutType { get; set; }

    [ForeignKey("PackTypeId")]
    //[InverseProperty("StockWarehousePackTypes")]
    public virtual StockPickingType? PackType { get; set; }

    [ForeignKey("PartnerId")]
    //[InverseProperty("StockWarehouses")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("PbmLocId")]
    //[InverseProperty("StockWarehousePbmLocs")]
    public virtual StockLocation? PbmLoc { get; set; }

    [ForeignKey("PbmMtoPullId")]
    //[InverseProperty("StockWarehousePbmMtoPulls")]
    public virtual StockRule? PbmMtoPull { get; set; }

    [ForeignKey("PbmRouteId")]
    //[InverseProperty("StockWarehousePbmRoutes")]
    public virtual StockRoute? PbmRoute { get; set; }

    [ForeignKey("PbmTypeId")]
    //[InverseProperty("StockWarehousePbmTypes")]
    public virtual StockPickingType? PbmType { get; set; }

    [ForeignKey("PickTypeId")]
    //[InverseProperty("StockWarehousePickTypes")]
    public virtual StockPickingType? PickType { get; set; }

    [ForeignKey("PosTypeId")]
    //[InverseProperty("StockWarehousePosTypes")]
    public virtual StockPickingType? PosType { get; set; }

    [ForeignKey("ReceptionRouteId")]
    //[InverseProperty("StockWarehouseReceptionRoutes")]
    public virtual StockRoute? ReceptionRoute { get; set; }

    [ForeignKey("ReturnTypeId")]
    //[InverseProperty("StockWarehouseReturnTypes")]
    public virtual StockPickingType? ReturnType { get; set; }

    [ForeignKey("SamLocId")]
    //[InverseProperty("StockWarehouseSamLocs")]
    public virtual StockLocation? SamLoc { get; set; }

    [ForeignKey("SamRuleId")]
    //[InverseProperty("StockWarehouseSamRules")]
    public virtual StockRule? SamRule { get; set; }

    [ForeignKey("SamTypeId")]
    //[InverseProperty("StockWarehouseSamTypes")]
    public virtual StockPickingType? SamType { get; set; }

    [ForeignKey("ViewLocationId")]
    //[InverseProperty("StockWarehouseViewLocations")]
    public virtual StockLocation? ViewLocation { get; set; }

    [ForeignKey("WhInputStockLocId")]
    //[InverseProperty("StockWarehouseWhInputStockLocs")]
    public virtual StockLocation? WhInputStockLoc { get; set; }

    [ForeignKey("WhOutputStockLocId")]
    //[InverseProperty("StockWarehouseWhOutputStockLocs")]
    public virtual StockLocation? WhOutputStockLoc { get; set; }

    [ForeignKey("WhPackStockLocId")]
    //[InverseProperty("StockWarehouseWhPackStockLocs")]
    public virtual StockLocation? WhPackStockLoc { get; set; }

    [ForeignKey("WhQcStockLocId")]
    //[InverseProperty("StockWarehouseWhQcStockLocs")]
    public virtual StockLocation? WhQcStockLoc { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("StockWarehouseWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("Warehouse")]
    [NotMapped]
    public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();

    [InverseProperty("Warehouse")]
    [NotMapped]
    public virtual ICollection<ProductReplenish> ProductReplenishes { get; } = new List<ProductReplenish>();

    [InverseProperty("Warehouse")]
    [NotMapped]
    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    [InverseProperty("Warehouse")]
    [NotMapped]
    public virtual ICollection<StockLocation> StockLocations { get; } = new List<StockLocation>();

    [InverseProperty("Warehouse")]
    [NotMapped]
    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    [InverseProperty("Warehouse")]
    [NotMapped]
    public virtual ICollection<StockPickingType> StockPickingTypes { get; } = new List<StockPickingType>();

    [InverseProperty("SuppliedWh")]
    [NotMapped]
    public virtual ICollection<StockRoute> StockRouteSuppliedWhs { get; } = new List<StockRoute>();

    [InverseProperty("SupplierWh")]
    [NotMapped]
    public virtual ICollection<StockRoute> StockRouteSupplierWhs { get; } = new List<StockRoute>();

    [InverseProperty("PropagateWarehouse")]
    [NotMapped]
    public virtual ICollection<StockRule> StockRulePropagateWarehouses { get; } = new List<StockRule>();

    [InverseProperty("Warehouse")]
    [NotMapped]
    public virtual ICollection<StockRule> StockRuleWarehouses { get; } = new List<StockRule>();

    [InverseProperty("Warehouse")]
    [NotMapped]
    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; } = new List<StockWarehouseOrderpoint>();

    [InverseProperty("Warehouse")]
    [NotMapped]
    public virtual ICollection<Website> Websites { get; } = new List<Website>();

    [ForeignKey("WarehouseId")]
    [InverseProperty("Warehouses")]
    [NotMapped]
    public virtual ICollection<StockRoute> Routes { get; } = new List<StockRoute>();

    [ForeignKey("StockWarehouseId")]
    [InverseProperty("StockWarehouses")]
    [NotMapped]
    public virtual ICollection<StockRulesReport> StockRulesReports { get; } = new List<StockRulesReport>();

    [ForeignKey("SupplierWhId")]
    [InverseProperty("SupplierWhs")]
    [NotMapped]
    public virtual ICollection<StockWarehouse> SuppliedWhs { get; } = new List<StockWarehouse>();

    [ForeignKey("SuppliedWhId")]
    [InverseProperty("SuppliedWhs")]
    [NotMapped]
    public virtual ICollection<StockWarehouse> SupplierWhs { get; } = new List<StockWarehouse>();
}
