using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_change_product_qty")]
public partial class StockChangeProductQty
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("product_tmpl_id")]
    public Guid? ProductTmplId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("new_quantity")]
    public decimal? NewQuantity { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockChangeProductQtyCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("StockChangeProductQties")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("ProductTmplId")]
    [InverseProperty("StockChangeProductQties")]
    public virtual ProductTemplate? ProductTmpl { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("StockChangeProductQtyWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
