using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_warn_insufficient_qty_scrap")]
public partial class StockWarnInsufficientQtyScrap
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("location_id")]
    public Guid? LocationId { get; set; }

    [Column("scrap_id")]
    public Guid? ScrapId { get; set; }

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
    [InverseProperty("StockWarnInsufficientQtyScrapCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LocationId")]
    [InverseProperty("StockWarnInsufficientQtyScraps")]
    public virtual StockLocation? Location { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("StockWarnInsufficientQtyScraps")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("ScrapId")]
    [InverseProperty("StockWarnInsufficientQtyScraps")]
    public virtual StockScrap? Scrap { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("StockWarnInsufficientQtyScrapWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
