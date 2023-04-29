using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_picking")]
[Index("CompanyId", Name = "stock_picking_company_id_index")]
[Index("Name", "CompanyId", Name = "stock_picking_name_uniq", IsUnique = true)]
[Index("PickingTypeId", Name = "stock_picking_picking_type_id_index")]
[Index("ScheduledDate", Name = "stock_picking_scheduled_date_index")]
[Index("State", Name = "stock_picking_state_index")]
public partial class StockPicking
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("backorder_id")]
    public Guid? BackorderId { get; set; }

    [Column("group_id")]
    public Guid? GroupId { get; set; }

    [Column("location_id")]
    public Guid? LocationId { get; set; }

    [Column("location_dest_id")]
    public Guid? LocationDestId { get; set; }

    [Column("picking_type_id")]
    public Guid? PickingTypeId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("owner_id")]
    public Guid? OwnerId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("origin")]
    public string? Origin { get; set; }

    [Column("move_type")]
    public string? MoveType { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("priority")]
    public string? Priority { get; set; }

    [Column("note")]
    public string? Note { get; set; }

    [Column("has_deadline_issue")]
    public bool? HasDeadlineIssue { get; set; }

    [Column("printed")]
    public bool? Printed { get; set; }

    [Column("is_locked")]
    public bool? IsLocked { get; set; }

    [Column("immediate_transfer")]
    public bool? ImmediateTransfer { get; set; }

    [Column("scheduled_date", TypeName = "timestamp without time zone")]
    public DateTime? ScheduledDate { get; set; }

    [Column("date_deadline", TypeName = "timestamp without time zone")]
    public DateTime? DateDeadline { get; set; }

    [Column("date", TypeName = "timestamp without time zone")]
    public DateTime? Date { get; set; }

    [Column("date_done", TypeName = "timestamp without time zone")]
    public DateTime? DateDone { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("pos_session_id")]
    public Guid? PosSessionId { get; set; }

    [Column("pos_order_id")]
    public Guid? PosOrderId { get; set; }

    [Column("sale_id")]
    public Guid? SaleId { get; set; }

    [Column("website_id")]
    public Guid? WebsiteId { get; set; }

    [ForeignKey("BackorderId")]
    [InverseProperty("InverseBackorder")]
    public virtual StockPicking? Backorder { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("StockPickings")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockPickingCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("GroupId")]
    [InverseProperty("StockPickings")]
    public virtual ProcurementGroup? Group { get; set; }

    [InverseProperty("Backorder")]
    public virtual ICollection<StockPicking> InverseBackorder { get; } = new List<StockPicking>();

    [ForeignKey("LocationId")]
    [InverseProperty("StockPickingLocations")]
    public virtual StockLocation? Location { get; set; }

    [ForeignKey("LocationDestId")]
    [InverseProperty("StockPickingLocationDests")]
    public virtual StockLocation? LocationDest { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("StockPickings")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("OwnerId")]
    [InverseProperty("StockPickingOwners")]
    public virtual ResPartner? Owner { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("StockPickingPartners")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("PickingTypeId")]
    [InverseProperty("StockPickings")]
    public virtual StockPickingType? PickingType { get; set; }

    [ForeignKey("PosOrderId")]
    [InverseProperty("StockPickings")]
    public virtual PosOrder? PosOrder { get; set; }

    [ForeignKey("PosSessionId")]
    [InverseProperty("StockPickings")]
    public virtual PosSession? PosSession { get; set; }

    [InverseProperty("Picking")]
    public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

    [ForeignKey("SaleId")]
    [InverseProperty("StockPickings")]
    public virtual SaleOrder? Sale { get; set; }

    [InverseProperty("Picking")]
    public virtual ICollection<StockBackorderConfirmationLine> StockBackorderConfirmationLines { get; } = new List<StockBackorderConfirmationLine>();

    [InverseProperty("Picking")]
    public virtual ICollection<StockImmediateTransferLine> StockImmediateTransferLines { get; } = new List<StockImmediateTransferLine>();

    [InverseProperty("Picking")]
    public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();

    [InverseProperty("Picking")]
    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    [InverseProperty("Picking")]
    public virtual ICollection<StockPackageDestination> StockPackageDestinations { get; } = new List<StockPackageDestination>();

    [InverseProperty("Picking")]
    public virtual ICollection<StockPackageLevel> StockPackageLevels { get; } = new List<StockPackageLevel>();

    [InverseProperty("Picking")]
    public virtual ICollection<StockReturnPicking> StockReturnPickings { get; } = new List<StockReturnPicking>();

    [InverseProperty("Picking")]
    public virtual ICollection<StockScrap> StockScraps { get; } = new List<StockScrap>();

    [ForeignKey("UserId")]
    [InverseProperty("StockPickingUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WebsiteId")]
    [InverseProperty("StockPickings")]
    public virtual Website? Website { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("StockPickingWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("StockPickingId")]
    [InverseProperty("StockPickings")]
    public virtual ICollection<ConfirmStockSm> ConfirmStockSms { get; } = new List<ConfirmStockSm>();

    [ForeignKey("StockPickingId")]
    [InverseProperty("StockPickings")]
    public virtual ICollection<LotLabelLayout> LotLabelLayouts { get; } = new List<LotLabelLayout>();

    [ForeignKey("StockPickingId")]
    [InverseProperty("StockPickings")]
    public virtual ICollection<PickingLabelType> PickingLabelTypes { get; } = new List<PickingLabelType>();

    [ForeignKey("StockPickingId")]
    [InverseProperty("StockPickings")]
    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

    [ForeignKey("StockPickingId")]
    [InverseProperty("StockPickings")]
    public virtual ICollection<StockBackorderConfirmation> StockBackorderConfirmations { get; } = new List<StockBackorderConfirmation>();

    [ForeignKey("StockPickingId")]
    [InverseProperty("StockPickings")]
    public virtual ICollection<StockImmediateTransfer> StockImmediateTransfers { get; } = new List<StockImmediateTransfer>();
}
