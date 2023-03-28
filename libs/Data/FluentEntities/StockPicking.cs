using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockPicking
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? BackorderId { get; set; }

    public Guid? GroupId { get; set; }

    public Guid? LocationId { get; set; }

    public Guid? LocationDestId { get; set; }

    public Guid? PickingTypeId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? OwnerId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Origin { get; set; }

    public string? MoveType { get; set; }

    public string? State { get; set; }

    public string? Priority { get; set; }

    public string? Note { get; set; }

    public bool? HasDeadlineIssue { get; set; }

    public bool? Printed { get; set; }

    public bool? IsLocked { get; set; }

    public bool? ImmediateTransfer { get; set; }

    public DateTime? ScheduledDate { get; set; }

    public DateTime? DateDeadline { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? DateDone { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? PosSessionId { get; set; }

    public Guid? PosOrderId { get; set; }

    public Guid? SaleId { get; set; }

    public Guid? WebsiteId { get; set; }

    public virtual StockPicking? Backorder { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProcurementGroup? Group { get; set; }

    //public virtual ICollection<StockPicking> InverseBackorder { get; } = new List<StockPicking>();

    public virtual StockLocation? Location { get; set; }

    public virtual StockLocation? LocationDest { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner? Owner { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual StockPickingType? PickingType { get; set; }

    public virtual PosOrder? PosOrder { get; set; }

    public virtual PosSession? PosSession { get; set; }

    //public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    public virtual SaleOrder? Sale { get; set; }

    //public virtual ICollection<StockBackorderConfirmationLine> StockBackorderConfirmationLines { get; } = new List<StockBackorderConfirmationLine>();

    //public virtual ICollection<StockImmediateTransferLine> StockImmediateTransferLines { get; } = new List<StockImmediateTransferLine>();

    //public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();

    //public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    //public virtual ICollection<StockPackageDestination> StockPackageDestinations { get; } = new List<StockPackageDestination>();

    //public virtual ICollection<StockPackageLevel> StockPackageLevels { get; } = new List<StockPackageLevel>();

    //public virtual ICollection<StockReturnPicking> StockReturnPickings { get; } = new List<StockReturnPicking>();

    //public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    public virtual ResUser? User { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ConfirmStockSm> ConfirmStockSms { get; } = new List<ConfirmStockSm>();

    //public virtual ICollection<LotLabelLayout> LotLabelLayouts { get; } = new List<LotLabelLayout>();

    //public virtual ICollection<PickingLabelType> PickingLabelTypes { get; } = new List<PickingLabelType>();

    //public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

    //public virtual ICollection<StockBackorderConfirmation> StockBackorderConfirmations { get; } = new List<StockBackorderConfirmation>();

    //public virtual ICollection<StockImmediateTransfer> StockImmediateTransfers { get; } = new List<StockImmediateTransfer>();
}
