using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_warn_insufficient_qty_unbuild")]
public partial class StockWarnInsufficientQtyUnbuild
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("location_id")]
    public Guid? LocationId { get; set; }

    [Column("unbuild_id")]
    public Guid? UnbuildId { get; set; }

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
    [InverseProperty("StockWarnInsufficientQtyUnbuildCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LocationId")]
    [InverseProperty("StockWarnInsufficientQtyUnbuilds")]
    public virtual StockLocation? Location { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("StockWarnInsufficientQtyUnbuilds")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("UnbuildId")]
    [InverseProperty("StockWarnInsufficientQtyUnbuilds")]
    public virtual MrpUnbuild? Unbuild { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("StockWarnInsufficientQtyUnbuildWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
