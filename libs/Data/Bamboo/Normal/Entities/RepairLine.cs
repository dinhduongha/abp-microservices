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

[Table("repair_line")]
[Index("TenantId", Name = "repair_line_company_id_index")]
[Index("LocationDestId", Name = "repair_line_location_dest_id_index")]
[Index("LocationId", Name = "repair_line_location_id_index")]
[Index("RepairId", Name = "repair_line_repair_id_index")]
public partial class RepairLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("repair_id")]
    public Guid? RepairId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("product_uom")]
    public Guid? ProductUom { get; set; }

    [Column("invoice_line_id")]
    public Guid? InvoiceLineId { get; set; }

    [Column("location_id")]
    public Guid? LocationId { get; set; }

    [Column("location_dest_id")]
    public Guid? LocationDestId { get; set; }

    [Column("move_id")]
    public Guid? MoveId { get; set; }

    [Column("lot_id")]
    public Guid? LotId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("type")]
    public string? Type { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("price_unit")]
    public decimal? PriceUnit { get; set; }

    [Column("price_subtotal")]
    public decimal? PriceSubtotal { get; set; }

    [Column("price_total")]
    public decimal? PriceTotal { get; set; }

    [Column("product_uom_qty")]
    public decimal? ProductUomQty { get; set; }

    [Column("invoiced")]
    public bool? Invoiced { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("TenantId")]
    //[InverseProperty("RepairLines")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("RepairLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("InvoiceLineId")]
    //[InverseProperty("RepairLines")]
    public virtual AccountMoveLine? InvoiceLine { get; set; }

    [ForeignKey("LocationId")]
    //[InverseProperty("RepairLineLocations")]
    public virtual StockLocation? Location { get; set; }

    [ForeignKey("LocationDestId")]
    //[InverseProperty("RepairLineLocationDests")]
    public virtual StockLocation? LocationDest { get; set; }

    [ForeignKey("LotId")]
    //[InverseProperty("RepairLines")]
    public virtual StockLot? Lot { get; set; }

    [ForeignKey("MoveId")]
    //[InverseProperty("RepairLines")]
    public virtual StockMove? Move { get; set; }

    [ForeignKey("ProductId")]
    //[InverseProperty("RepairLines")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("ProductUom")]
    //[InverseProperty("RepairLines")]
    public virtual UomUom? ProductUomNavigation { get; set; }

    [ForeignKey("RepairId")]
    //[InverseProperty("RepairLines")]
    public virtual RepairOrder? Repair { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("RepairLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("RepairOperationLineId")]
    [InverseProperty("RepairOperationLines")]
    [NotMapped]
    public virtual ICollection<AccountTax> Taxes { get; } = new List<AccountTax>();
}
