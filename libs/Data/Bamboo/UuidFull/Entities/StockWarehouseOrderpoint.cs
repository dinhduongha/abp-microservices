﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_warehouse_orderpoint")]
[Index("CompanyId", Name = "stock_warehouse_orderpoint_company_id_index")]
[Index("LocationId", Name = "stock_warehouse_orderpoint_location_id_index")]
[Index("ProductId", "LocationId", "CompanyId", Name = "stock_warehouse_orderpoint_product_location_check", IsUnique = true)]
public partial class StockWarehouseOrderpoint
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("warehouse_id")]
    public Guid? WarehouseId { get; set; }

    [Column("location_id")]
    public Guid? LocationId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("product_category_id")]
    public long? ProductCategoryId { get; set; }

    [Column("group_id")]
    public Guid? GroupId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("route_id")]
    public Guid? RouteId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("trigger")]
    public string? Trigger { get; set; }

    [Column("snoozed_until")]
    public DateOnly? SnoozedUntil { get; set; }

    [Column("product_min_qty")]
    public decimal? ProductMinQty { get; set; }

    [Column("product_max_qty")]
    public decimal? ProductMaxQty { get; set; }

    [Column("qty_multiple")]
    public decimal? QtyMultiple { get; set; }

    [Column("qty_to_order")]
    public decimal? QtyToOrder { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("supplier_id")]
    public Guid? SupplierId { get; set; }

    [Column("vendor_id")]
    public Guid? VendorId { get; set; }

    [Column("purchase_visibility_days")]
    public double? PurchaseVisibilityDays { get; set; }

    [Column("bom_id")]
    public Guid? BomId { get; set; }

    [Column("manufacturing_visibility_days")]
    public double? ManufacturingVisibilityDays { get; set; }

    [ForeignKey("BomId")]
    [InverseProperty("StockWarehouseOrderpoints")]
    public virtual MrpBom? Bom { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("StockWarehouseOrderpoints")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockWarehouseOrderpointCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("GroupId")]
    [InverseProperty("StockWarehouseOrderpoints")]
    public virtual ProcurementGroup? Group { get; set; }

    [ForeignKey("LocationId")]
    [InverseProperty("StockWarehouseOrderpoints")]
    public virtual StockLocation? Location { get; set; }

    [InverseProperty("Orderpoint")]
    public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();

    [ForeignKey("ProductId")]
    [InverseProperty("StockWarehouseOrderpoints")]
    public virtual ProductProduct? Product { get; set; }

    [InverseProperty("Orderpoint")]
    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    [ForeignKey("RouteId")]
    [InverseProperty("StockWarehouseOrderpoints")]
    public virtual StockRoute? Route { get; set; }

    [InverseProperty("Orderpoint")]
    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    [InverseProperty("Orderpoint")]
    public virtual ICollection<StockReplenishmentInfo> StockReplenishmentInfos { get; } = new List<StockReplenishmentInfo>();

    [ForeignKey("SupplierId")]
    [InverseProperty("StockWarehouseOrderpoints")]
    public virtual ProductSupplierinfo? Supplier { get; set; }

    [ForeignKey("VendorId")]
    [InverseProperty("StockWarehouseOrderpoints")]
    public virtual ResPartner? Vendor { get; set; }

    [ForeignKey("WarehouseId")]
    [InverseProperty("StockWarehouseOrderpoints")]
    public virtual StockWarehouse? Warehouse { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("StockWarehouseOrderpointWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("StockWarehouseOrderpointId")]
    [InverseProperty("StockWarehouseOrderpoints")]
    public virtual ICollection<StockOrderpointSnooze> StockOrderpointSnoozes { get; } = new List<StockOrderpointSnooze>();
}
