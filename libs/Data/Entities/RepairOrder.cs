using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("repair_order")]
[Index("TenantId", Name = "repair_order_company_id_index")]
[Index("InvoiceMethod", Name = "repair_order_invoice_method_index")]
[Index("LocationId", Name = "repair_order_location_id_index")]
[Index("Name", Name = "repair_order_name", IsUnique = true)]
[Index("PartnerId", Name = "repair_order_partner_id_index")]
public partial class RepairOrder
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("product_uom")]
    public Guid? ProductUom { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("address_id")]
    public Guid? AddressId { get; set; }

    [Column("location_id")]
    public Guid? LocationId { get; set; }

    [Column("lot_id")]
    public Guid? LotId { get; set; }

    [Column("pricelist_id")]
    public Guid? PricelistId { get; set; }

    [Column("partner_invoice_id")]
    public Guid? PartnerInvoiceId { get; set; }

    [Column("invoice_id")]
    public Guid? InvoiceId { get; set; }

    [Column("move_id")]
    public Guid? MoveId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("sale_order_id")]
    public Guid? SaleOrderId { get; set; }

    [Column("picking_id")]
    public Guid? PickingId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("invoice_method")]
    public string? InvoiceMethod { get; set; }

    [Column("priority")]
    public string? Priority { get; set; }

    [Column("schedule_date")]
    public DateOnly? ScheduleDate { get; set; }

    [Column("guarantee_limit")]
    public DateOnly? GuaranteeLimit { get; set; }

    [Column("internal_notes")]
    public string? InternalNotes { get; set; }

    [Column("quotation_notes")]
    public string? QuotationNotes { get; set; }

    [Column("product_qty")]
    public decimal? ProductQty { get; set; }

    [Column("invoiced")]
    public bool? Invoiced { get; set; }

    [Column("repaired")]
    public bool? Repaired { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("amount_untaxed")]
    public double? AmountUntaxed { get; set; }

    [Column("amount_tax")]
    public double? AmountTax { get; set; }

    [Column("amount_total")]
    public double? AmountTotal { get; set; }

    [ForeignKey("AddressId")]
    [InverseProperty("RepairOrderAddresses")]
    public virtual ResPartner? Address { get; set; }

    [ForeignKey("TenantId")]
    [InverseProperty("RepairOrders")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("RepairOrderCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("InvoiceId")]
    [InverseProperty("RepairOrders")]
    public virtual AccountMove? Invoice { get; set; }

    [ForeignKey("LocationId")]
    [InverseProperty("RepairOrders")]
    public virtual StockLocation? Location { get; set; }

    [ForeignKey("LotId")]
    [InverseProperty("RepairOrders")]
    public virtual StockLot? Lot { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("RepairOrders")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("MoveId")]
    [InverseProperty("RepairOrders")]
    public virtual StockMove? Move { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("RepairOrderPartners")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("PartnerInvoiceId")]
    [InverseProperty("RepairOrderPartnerInvoices")]
    public virtual ResPartner? PartnerInvoice { get; set; }

    [ForeignKey("PickingId")]
    [InverseProperty("RepairOrders")]
    public virtual StockPicking? Picking { get; set; }

    [ForeignKey("PricelistId")]
    [InverseProperty("RepairOrders")]
    public virtual ProductPricelist? Pricelist { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("RepairOrders")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("ProductUom")]
    [InverseProperty("RepairOrders")]
    public virtual UomUom? ProductUomNavigation { get; set; }

    [InverseProperty("Repair")]
    [NotMapped]
    public virtual ICollection<RepairFee> RepairFees { get; } = new List<RepairFee>();

    [InverseProperty("Repair")]
    [NotMapped]
    public virtual ICollection<RepairLine> RepairLines { get; } = new List<RepairLine>();

    [ForeignKey("SaleOrderId")]
    [InverseProperty("RepairOrders")]
    public virtual SaleOrder? SaleOrder { get; set; }

    [InverseProperty("Repair")]
    [NotMapped]
    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    [InverseProperty("Repair")]
    [NotMapped]
    public virtual ICollection<StockWarnInsufficientQtyRepair> StockWarnInsufficientQtyRepairs { get; } = new List<StockWarnInsufficientQtyRepair>();

    [ForeignKey("UserId")]
    [InverseProperty("RepairOrderUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("RepairOrderWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("RepairOrderId")]
    [InverseProperty("RepairOrders")]
    [NotMapped]
    public virtual ICollection<RepairTag> RepairTags { get; } = new List<RepairTag>();
}
