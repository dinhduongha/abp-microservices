﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("purchase_order")]
[Index("CompanyId", Name = "purchase_order_company_id_index")]
[Index("DateApprove", Name = "purchase_order_date_approve_index")]
[Index("DateOrder", Name = "purchase_order_date_order_index")]
[Index("DatePlanned", Name = "purchase_order_date_planned_index")]
[Index("Priority", Name = "purchase_order_priority_index")]
[Index("State", Name = "purchase_order_state_index")]
[Index("UserId", Name = "purchase_order_user_id_index")]
public partial class PurchaseOrder
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("dest_address_id")]
    public Guid? DestAddressId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("invoice_count")]
    public long? InvoiceCount { get; set; }

    [Column("fiscal_position_id")]
    public Guid? FiscalPositionId { get; set; }

    [Column("payment_term_id")]
    public Guid? PaymentTermId { get; set; }

    [Column("incoterm_id")]
    public Guid? IncotermId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("access_token")]
    public string? AccessToken { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("priority")]
    public string? Priority { get; set; }

    [Column("origin")]
    public string? Origin { get; set; }

    [Column("partner_ref")]
    public string? PartnerRef { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("invoice_status")]
    public string? InvoiceStatus { get; set; }

    [Column("notes")]
    public string? Notes { get; set; }

    [Column("amount_untaxed")]
    public decimal? AmountUntaxed { get; set; }

    [Column("amount_tax")]
    public decimal? AmountTax { get; set; }

    [Column("amount_total")]
    public decimal? AmountTotal { get; set; }

    [Column("mail_reminder_confirmed")]
    public bool? MailReminderConfirmed { get; set; }

    [Column("mail_reception_confirmed")]
    public bool? MailReceptionConfirmed { get; set; }

    [Column("date_order", TypeName = "timestamp without time zone")]
    public DateTime? DateOrder { get; set; }

    [Column("date_approve", TypeName = "timestamp without time zone")]
    public DateTime? DateApprove { get; set; }

    [Column("date_planned", TypeName = "timestamp without time zone")]
    public DateTime? DatePlanned { get; set; }

    [Column("date_calendar_start", TypeName = "timestamp without time zone")]
    public DateTime? DateCalendarStart { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("currency_rate")]
    public double? CurrencyRate { get; set; }

    [Column("picking_type_id")]
    public Guid? PickingTypeId { get; set; }

    [Column("group_id")]
    public Guid? GroupId { get; set; }

    [Column("incoterm_location")]
    public string? IncotermLocation { get; set; }

    [Column("receipt_status")]
    public string? ReceiptStatus { get; set; }

    [Column("effective_date", TypeName = "timestamp without time zone")]
    public DateTime? EffectiveDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("PurchaseOrders")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("PurchaseOrderCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("DestAddressId")]
    [InverseProperty("PurchaseOrderDestAddresses")]
    public virtual ResPartner? DestAddress { get; set; }

    [ForeignKey("FiscalPositionId")]
    [InverseProperty("PurchaseOrders")]
    public virtual AccountFiscalPosition? FiscalPosition { get; set; }

    [ForeignKey("GroupId")]
    [InverseProperty("PurchaseOrders")]
    public virtual ProcurementGroup? Group { get; set; }

    [ForeignKey("IncotermId")]
    [InverseProperty("PurchaseOrders")]
    public virtual AccountIncoterm? Incoterm { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("PurchaseOrders")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("PurchaseOrderPartners")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("PaymentTermId")]
    [InverseProperty("PurchaseOrders")]
    public virtual AccountPaymentTerm? PaymentTerm { get; set; }

    [ForeignKey("PickingTypeId")]
    [InverseProperty("PurchaseOrders")]
    public virtual StockPickingType? PickingType { get; set; }

    [InverseProperty("Order")]
    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

    [ForeignKey("UserId")]
    [InverseProperty("PurchaseOrderUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("PurchaseOrderWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("PurchaseOrderId")]
    [InverseProperty("PurchaseOrders")]
    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    [ForeignKey("PurchaseOrderId")]
    [InverseProperty("PurchaseOrders")]
    public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();
}