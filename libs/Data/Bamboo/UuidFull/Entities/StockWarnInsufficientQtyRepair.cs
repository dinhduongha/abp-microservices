using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_warn_insufficient_qty_repair")]
public partial class StockWarnInsufficientQtyRepair
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("location_id")]
    public Guid? LocationId { get; set; }

    [Column("repair_id")]
    public Guid? RepairId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("product_uom_name")]
    public string? ProductUomName { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("quantity")]
    public double? Quantity { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockWarnInsufficientQtyRepairCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LocationId")]
    [InverseProperty("StockWarnInsufficientQtyRepairs")]
    public virtual StockLocation? Location { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("StockWarnInsufficientQtyRepairs")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("RepairId")]
    [InverseProperty("StockWarnInsufficientQtyRepairs")]
    public virtual RepairOrder? Repair { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("StockWarnInsufficientQtyRepairWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
