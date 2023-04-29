using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("sale_order_option")]
[Index("OrderId", Name = "sale_order_option_order_id_index")]
public partial class SaleOrderOption
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("order_id")]
    public Guid? OrderId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("line_id")]
    public Guid? LineId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("uom_id")]
    public Guid? UomId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("quantity")]
    public decimal? Quantity { get; set; }

    [Column("price_unit")]
    public decimal? PriceUnit { get; set; }

    [Column("discount")]
    public decimal? Discount { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("SaleOrderOptionCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LineId")]
    [InverseProperty("SaleOrderOptions")]
    public virtual SaleOrderLine? Line { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("SaleOrderOptions")]
    public virtual SaleOrder? Order { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("SaleOrderOptions")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("UomId")]
    [InverseProperty("SaleOrderOptions")]
    public virtual UomUom? Uom { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("SaleOrderOptionWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
