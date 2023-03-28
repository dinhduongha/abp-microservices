using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockMove
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? ProductUom { get; set; }

    public Guid? LocationId { get; set; }

    public Guid? LocationDestId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? PickingId { get; set; }

    public Guid? GroupId { get; set; }

    public Guid? RuleId { get; set; }

    public Guid? PickingTypeId { get; set; }

    public Guid? OriginReturnedMoveId { get; set; }

    public Guid? RestrictPartnerId { get; set; }

    public Guid? WarehouseId { get; set; }

    public Guid? PackageLevelId { get; set; }

    public long? NextSerialCount { get; set; }

    public Guid? OrderpointId { get; set; }

    public Guid? ProductPackagingId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Priority { get; set; }

    public string? State { get; set; }

    public string? Origin { get; set; }

    public string? ProcureMethod { get; set; }

    public string? Reference { get; set; }

    public string? NextSerial { get; set; }

    public DateOnly? ReservationDate { get; set; }

    public string? DescriptionPicking { get; set; }

    public decimal? ProductQty { get; set; }

    public decimal? ProductUomQty { get; set; }

    public decimal? QuantityDone { get; set; }

    public bool? Scrapped { get; set; }

    public bool? PropagateCancel { get; set; }

    public bool? IsInventory { get; set; }

    public bool? Additional { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? DateDeadline { get; set; }

    public DateTime? DelayAlertDate { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? PriceUnit { get; set; }

    public Guid? AnalyticAccountLineId { get; set; }

    public bool? ToRefund { get; set; }

    public Guid? SaleLineId { get; set; }

    public Guid? PurchaseLineId { get; set; }

    public Guid? CreatedPurchaseLineId { get; set; }

    public Guid? RepairId { get; set; }

    public bool? IsDone { get; set; }

    public double? UnitFactor { get; set; }

    public Guid? CreatedProductionId { get; set; }

    public Guid? ProductionId { get; set; }

    public Guid? RawMaterialProductionId { get; set; }

    public Guid? UnbuildId { get; set; }

    public Guid? ConsumeUnbuildId { get; set; }

    public Guid? OperationId { get; set; }

    public Guid? WorkorderId { get; set; }

    public Guid? BomLineId { get; set; }

    public Guid? ByproductId { get; set; }

    public Guid? OrderFinishedLotId { get; set; }

    public decimal? CostShare { get; set; }

    public bool? ManualConsumption { get; set; }

    //public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    public virtual AccountAnalyticLine? AnalyticAccountLine { get; set; }

    public virtual MrpBomLine? BomLine { get; set; }

    public virtual MrpBomByproduct? Byproduct { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual MrpUnbuild? ConsumeUnbuild { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpProduction? CreatedProduction { get; set; }

    public virtual PurchaseOrderLine? CreatedPurchaseLine { get; set; }

    public virtual ProcurementGroup? Group { get; set; }

    //public virtual ICollection<StockMove> InverseOriginReturnedMove { get; } = new List<StockMove>();

    public virtual StockLocation? Location { get; set; }

    public virtual StockLocation? LocationDest { get; set; }

    public virtual MrpRoutingWorkcenter? Operation { get; set; }

    public virtual StockLot? OrderFinishedLot { get; set; }

    public virtual StockWarehouseOrderpoint? Orderpoint { get; set; }

    public virtual StockMove? OriginReturnedMove { get; set; }

    public virtual StockPackageLevel? PackageLevel { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual StockPicking? Picking { get; set; }

    public virtual StockPickingType? PickingType { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ProductPackaging? ProductPackaging { get; set; }

    public virtual UomUom? ProductUomNavigation { get; set; }

    public virtual MrpProduction? Production { get; set; }

    public virtual PurchaseOrderLine? PurchaseLine { get; set; }

    public virtual MrpProduction? RawMaterialProduction { get; set; }

    public virtual RepairOrder? Repair { get; set; }

    //public virtual ICollection<RepairLine> RepairLines { get; } = new List<RepairLine>();

    //public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    public virtual ResPartner? RestrictPartner { get; set; }

    public virtual StockRule? Rule { get; set; }

    public virtual SaleOrderLine? SaleLine { get; set; }

    //public virtual ICollection<StockAssignSerial> StockAssignSerials { get; } = new List<StockAssignSerial>();

    //public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();

    //public virtual ICollection<StockReturnPickingLine> StockReturnPickingLines { get; } = new List<StockReturnPickingLine>();

    //public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    //public virtual ICollection<StockValuationLayer> StockValuationLayers { get; } = new List<StockValuationLayer>();

    public virtual MrpUnbuild? Unbuild { get; set; }

    public virtual StockWarehouse? Warehouse { get; set; }

    public virtual MrpWorkorder? Workorder { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<StockMove> MoveDests { get; } = new List<StockMove>();

    //public virtual ICollection<StockMove> MoveOrigs { get; } = new List<StockMove>();

    //public virtual ICollection<StockRoute> Routes { get; } = new List<StockRoute>();
}
