using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class RepairOrder
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? ProductUom { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? AddressId { get; set; }

    public Guid? LocationId { get; set; }

    public Guid? LotId { get; set; }

    public Guid? PricelistId { get; set; }

    public Guid? PartnerInvoiceId { get; set; }

    public Guid? InvoiceId { get; set; }

    public Guid? MoveId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? SaleOrderId { get; set; }

    public Guid? PickingId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? State { get; set; }

    public string? InvoiceMethod { get; set; }

    public string? Priority { get; set; }

    public DateOnly? ScheduleDate { get; set; }

    public DateOnly? GuaranteeLimit { get; set; }

    public string? InternalNotes { get; set; }

    public string? QuotationNotes { get; set; }

    public decimal? ProductQty { get; set; }

    public bool? Invoiced { get; set; }

    public bool? Repaired { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? AmountUntaxed { get; set; }

    public double? AmountTax { get; set; }

    public double? AmountTotal { get; set; }

    public virtual ResPartner? Address { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountMove? Invoice { get; set; }

    public virtual StockLocation? Location { get; set; }

    public virtual StockLot? Lot { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual StockMove? Move { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResPartner? PartnerInvoice { get; set; }

    public virtual StockPicking? Picking { get; set; }

    public virtual ProductPricelist? Pricelist { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? ProductUomNavigation { get; set; }

    //public virtual ICollection<RepairFee> RepairFees { get; } = new List<RepairFee>();

    //public virtual ICollection<RepairLine> RepairLines { get; } = new List<RepairLine>();

    public virtual SaleOrder? SaleOrder { get; set; }

    //public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    //public virtual ICollection<StockWarnInsufficientQtyRepair> StockWarnInsufficientQtyRepairs { get; } = new List<StockWarnInsufficientQtyRepair>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<RepairTag> RepairTags { get; } = new List<RepairTag>();
}
