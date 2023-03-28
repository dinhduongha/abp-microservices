using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MrpProduction
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public long BackorderSequence { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? ProductUomId { get; set; }

    public Guid? LotProducingId { get; set; }

    public Guid? PickingTypeId { get; set; }

    public Guid? LocationSrcId { get; set; }

    public Guid? LocationDestId { get; set; }

    public Guid? BomId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? ProcurementGroupId { get; set; }

    public Guid? OrderpointId { get; set; }

    public Guid? ProductionLocationId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Priority { get; set; }

    public string? Origin { get; set; }

    public string? State { get; set; }

    public string? ReservationState { get; set; }

    public string? ProductDescriptionVariants { get; set; }

    public string? Consumption { get; set; }

    public decimal? ProductQty { get; set; }

    public decimal? QtyProducing { get; set; }

    public bool? PropagateCancel { get; set; }

    public bool? IsLocked { get; set; }

    public bool? IsPlanned { get; set; }

    public bool? AllowWorkorderDependencies { get; set; }

    public DateTime? DatePlannedStart { get; set; }

    public DateTime? DatePlannedFinished { get; set; }

    public DateTime? DateDeadline { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateFinished { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? ProductUomQty { get; set; }

    public Guid? AnalyticAccountId { get; set; }

    public double? ExtraCost { get; set; }

    public virtual AccountAnalyticAccount? AnalyticAccount { get; set; }

    public virtual MrpBom? Bom { get; set; }

    //public virtual ICollection<ChangeProductionQty> ChangeProductionQties { get; } = new List<ChangeProductionQty>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? LocationDest { get; set; }

    public virtual StockLocation? LocationSrc { get; set; }

    public virtual StockLot? LotProducing { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    //public virtual ICollection<MrpConsumptionWarningLine> MrpConsumptionWarningLines { get; } = new List<MrpConsumptionWarningLine>();

    //public virtual ICollection<MrpImmediateProductionLine> MrpImmediateProductionLines { get; } = new List<MrpImmediateProductionLine>();

    //public virtual ICollection<MrpProductionBackorderLine> MrpProductionBackorderLines { get; } = new List<MrpProductionBackorderLine>();

    //public virtual ICollection<MrpProductionSplit> MrpProductionSplits { get; } = new List<MrpProductionSplit>();

    //public virtual ICollection<MrpUnbuild> MrpUnbuilds { get; } = new List<MrpUnbuild>();

    //public virtual ICollection<MrpWorkorder> MrpWorkorders { get; } = new List<MrpWorkorder>();

    public virtual StockWarehouseOrderpoint? Orderpoint { get; set; }

    public virtual StockPickingType? PickingType { get; set; }

    public virtual ProcurementGroup? ProcurementGroup { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? ProductUom { get; set; }

    public virtual StockLocation? ProductionLocation { get; set; }

    //public virtual ICollection<StockAssignSerial> StockAssignSerials { get; } = new List<StockAssignSerial>();

    //public virtual ICollection<StockMove> StockMoveCreatedProductions { get; } = new List<StockMove>();

    //public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();

    //public virtual ICollection<StockMove> StockMoveProductions { get; } = new List<StockMove>();

    //public virtual ICollection<StockMove> StockMoveRawMaterialProductions { get; } = new List<StockMove>();

    //public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<MrpConsumptionWarning> MrpConsumptionWarnings { get; } = new List<MrpConsumptionWarning>();

    //public virtual ICollection<MrpImmediateProduction> MrpImmediateProductions { get; } = new List<MrpImmediateProduction>();

    //public virtual ICollection<MrpProductionBackorder> MrpProductionBackorders { get; } = new List<MrpProductionBackorder>();
}
