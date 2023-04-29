﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_move")]
[Index("CompanyId", Name = "stock_move_company_id_index")]
[Index("Date", Name = "stock_move_date_index")]
[Index("LocationDestId", Name = "stock_move_location_dest_id_index")]
[Index("LocationId", Name = "stock_move_location_id_index")]
[Index("OrderpointId", Name = "stock_move_orderpoint_id_index")]
[Index("OriginReturnedMoveId", Name = "stock_move_origin_returned_move_id_index")]
[Index("PickingId", Name = "stock_move_picking_id_index")]
[Index("ProductId", Name = "stock_move_product_id_index")]
[Index("ProductId", "LocationId", "LocationDestId", "CompanyId", "State", Name = "stock_move_product_location_index")]
[Index("State", Name = "stock_move_state_index")]
public partial class StockMove
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("product_uom")]
    public Guid? ProductUom { get; set; }

    [Column("location_id")]
    public Guid? LocationId { get; set; }

    [Column("location_dest_id")]
    public Guid? LocationDestId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("picking_id")]
    public Guid? PickingId { get; set; }

    [Column("group_id")]
    public Guid? GroupId { get; set; }

    [Column("rule_id")]
    public Guid? RuleId { get; set; }

    [Column("picking_type_id")]
    public Guid? PickingTypeId { get; set; }

    [Column("origin_returned_move_id")]
    public Guid? OriginReturnedMoveId { get; set; }

    [Column("restrict_partner_id")]
    public Guid? RestrictPartnerId { get; set; }

    [Column("warehouse_id")]
    public Guid? WarehouseId { get; set; }

    [Column("package_level_id")]
    public Guid? PackageLevelId { get; set; }

    [Column("next_serial_count")]
    public long? NextSerialCount { get; set; }

    [Column("orderpoint_id")]
    public Guid? OrderpointId { get; set; }

    [Column("product_packaging_id")]
    public Guid? ProductPackagingId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("priority")]
    public string? Priority { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("origin")]
    public string? Origin { get; set; }

    [Column("procure_method")]
    public string? ProcureMethod { get; set; }

    [Column("reference")]
    public string? Reference { get; set; }

    [Column("next_serial")]
    public string? NextSerial { get; set; }

    [Column("reservation_date")]
    public DateOnly? ReservationDate { get; set; }

    [Column("description_picking")]
    public string? DescriptionPicking { get; set; }

    [Column("product_qty")]
    public decimal? ProductQty { get; set; }

    [Column("product_uom_qty")]
    public decimal? ProductUomQty { get; set; }

    [Column("quantity_done")]
    public decimal? QuantityDone { get; set; }

    [Column("scrapped")]
    public bool? Scrapped { get; set; }

    [Column("propagate_cancel")]
    public bool? PropagateCancel { get; set; }

    [Column("is_inventory")]
    public bool? IsInventory { get; set; }

    [Column("additional")]
    public bool? Additional { get; set; }

    [Column("date", TypeName = "timestamp without time zone")]
    public DateTime? Date { get; set; }

    [Column("date_deadline", TypeName = "timestamp without time zone")]
    public DateTime? DateDeadline { get; set; }

    [Column("delay_alert_date", TypeName = "timestamp without time zone")]
    public DateTime? DelayAlertDate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("price_unit")]
    public double? PriceUnit { get; set; }

    [Column("analytic_account_line_id")]
    public Guid? AnalyticAccountLineId { get; set; }

    [Column("to_refund")]
    public bool? ToRefund { get; set; }

    [Column("sale_line_id")]
    public Guid? SaleLineId { get; set; }

    [Column("purchase_line_id")]
    public Guid? PurchaseLineId { get; set; }

    [Column("created_purchase_line_id")]
    public Guid? CreatedPurchaseLineId { get; set; }

    [Column("repair_id")]
    public Guid? RepairId { get; set; }

    [Column("is_done")]
    public bool? IsDone { get; set; }

    [Column("unit_factor")]
    public double? UnitFactor { get; set; }

    [Column("created_production_id")]
    public Guid? CreatedProductionId { get; set; }

    [Column("production_id")]
    public Guid? ProductionId { get; set; }

    [Column("raw_material_production_id")]
    public Guid? RawMaterialProductionId { get; set; }

    [Column("unbuild_id")]
    public Guid? UnbuildId { get; set; }

    [Column("consume_unbuild_id")]
    public Guid? ConsumeUnbuildId { get; set; }

    [Column("operation_id")]
    public Guid? OperationId { get; set; }

    [Column("workorder_id")]
    public Guid? WorkorderId { get; set; }

    [Column("bom_line_id")]
    public Guid? BomLineId { get; set; }

    [Column("byproduct_id")]
    public Guid? ByproductId { get; set; }

    [Column("order_finished_lot_id")]
    public Guid? OrderFinishedLotId { get; set; }

    [Column("cost_share")]
    public decimal? CostShare { get; set; }

    [Column("manual_consumption")]
    public bool? ManualConsumption { get; set; }

    [InverseProperty("StockMove")]
    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    [ForeignKey("AnalyticAccountLineId")]
    [InverseProperty("StockMoves")]
    public virtual AccountAnalyticLine? AnalyticAccountLine { get; set; }

    [ForeignKey("BomLineId")]
    [InverseProperty("StockMoves")]
    public virtual MrpBomLine? BomLine { get; set; }

    [ForeignKey("ByproductId")]
    [InverseProperty("StockMoves")]
    public virtual MrpBomByproduct? Byproduct { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("StockMoves")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("ConsumeUnbuildId")]
    [InverseProperty("StockMoveConsumeUnbuilds")]
    public virtual MrpUnbuild? ConsumeUnbuild { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockMoveCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CreatedProductionId")]
    [InverseProperty("StockMoveCreatedProductions")]
    public virtual MrpProduction? CreatedProduction { get; set; }

    [ForeignKey("CreatedPurchaseLineId")]
    [InverseProperty("StockMoveCreatedPurchaseLines")]
    public virtual PurchaseOrderLine? CreatedPurchaseLine { get; set; }

    [ForeignKey("GroupId")]
    [InverseProperty("StockMoves")]
    public virtual ProcurementGroup? Group { get; set; }

    [InverseProperty("OriginReturnedMove")]
    public virtual ICollection<StockMove> InverseOriginReturnedMove { get; } = new List<StockMove>();

    [ForeignKey("LocationId")]
    [InverseProperty("StockMoveLocations")]
    public virtual StockLocation? Location { get; set; }

    [ForeignKey("LocationDestId")]
    [InverseProperty("StockMoveLocationDests")]
    public virtual StockLocation? LocationDest { get; set; }

    [ForeignKey("OperationId")]
    [InverseProperty("StockMoves")]
    public virtual MrpRoutingWorkcenter? Operation { get; set; }

    [ForeignKey("OrderFinishedLotId")]
    [InverseProperty("StockMoves")]
    public virtual StockLot? OrderFinishedLot { get; set; }

    [ForeignKey("OrderpointId")]
    [InverseProperty("StockMoves")]
    public virtual StockWarehouseOrderpoint? Orderpoint { get; set; }

    [ForeignKey("OriginReturnedMoveId")]
    [InverseProperty("InverseOriginReturnedMove")]
    public virtual StockMove? OriginReturnedMove { get; set; }

    [ForeignKey("PackageLevelId")]
    [InverseProperty("StockMoves")]
    public virtual StockPackageLevel? PackageLevel { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("StockMovePartners")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("PickingId")]
    [InverseProperty("StockMoves")]
    public virtual StockPicking? Picking { get; set; }

    [ForeignKey("PickingTypeId")]
    [InverseProperty("StockMoves")]
    public virtual StockPickingType? PickingType { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("StockMoves")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("ProductPackagingId")]
    [InverseProperty("StockMoves")]
    public virtual ProductPackaging? ProductPackaging { get; set; }

    [ForeignKey("ProductUom")]
    [InverseProperty("StockMoves")]
    public virtual UomUom? ProductUomNavigation { get; set; }

    [ForeignKey("ProductionId")]
    [InverseProperty("StockMoveProductions")]
    public virtual MrpProduction? Production { get; set; }

    [ForeignKey("PurchaseLineId")]
    [InverseProperty("StockMovePurchaseLines")]
    public virtual PurchaseOrderLine? PurchaseLine { get; set; }

    [ForeignKey("RawMaterialProductionId")]
    [InverseProperty("StockMoveRawMaterialProductions")]
    public virtual MrpProduction? RawMaterialProduction { get; set; }

    [ForeignKey("RepairId")]
    [InverseProperty("StockMoves")]
    public virtual RepairOrder? Repair { get; set; }

    [InverseProperty("Move")]
    public virtual ICollection<RepairLine> RepairLines { get; } = new List<RepairLine>();

    [InverseProperty("Move")]
    public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    [ForeignKey("RestrictPartnerId")]
    [InverseProperty("StockMoveRestrictPartners")]
    public virtual ResPartner? RestrictPartner { get; set; }

    [ForeignKey("RuleId")]
    [InverseProperty("StockMoves")]
    public virtual StockRule? Rule { get; set; }

    [ForeignKey("SaleLineId")]
    [InverseProperty("StockMoves")]
    public virtual SaleOrderLine? SaleLine { get; set; }

    [InverseProperty("Move")]
    public virtual ICollection<StockAssignSerial> StockAssignSerials { get; } = new List<StockAssignSerial>();

    [InverseProperty("Move")]
    public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();

    [InverseProperty("Move")]
    public virtual ICollection<StockReturnPickingLine> StockReturnPickingLines { get; } = new List<StockReturnPickingLine>();

    [InverseProperty("Move")]
    public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    [InverseProperty("StockMove")]
    public virtual ICollection<StockValuationLayer> StockValuationLayers { get; } = new List<StockValuationLayer>();

    [ForeignKey("UnbuildId")]
    [InverseProperty("StockMoveUnbuilds")]
    public virtual MrpUnbuild? Unbuild { get; set; }

    [ForeignKey("WarehouseId")]
    [InverseProperty("StockMoves")]
    public virtual StockWarehouse? Warehouse { get; set; }

    [ForeignKey("WorkorderId")]
    [InverseProperty("StockMoves")]
    public virtual MrpWorkorder? Workorder { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("StockMoveWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("MoveOrigId")]
    [InverseProperty("MoveOrigs")]
    public virtual ICollection<StockMove> MoveDests { get; } = new List<StockMove>();

    [ForeignKey("MoveDestId")]
    [InverseProperty("MoveDests")]
    public virtual ICollection<StockMove> MoveOrigs { get; } = new List<StockMove>();

    [ForeignKey("MoveId")]
    [InverseProperty("Moves")]
    public virtual ICollection<StockRoute> Routes { get; } = new List<StockRoute>();
}
