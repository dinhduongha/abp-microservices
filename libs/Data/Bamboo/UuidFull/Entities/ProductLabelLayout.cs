using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("product_label_layout")]
public partial class ProductLabelLayout
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("custom_quantity")]
    public long? CustomQuantity { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("print_format")]
    public string? PrintFormat { get; set; }

    [Column("extra_html")]
    public string? ExtraHtml { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("picking_quantity")]
    public string? PickingQuantity { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProductLabelLayoutCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ProductLabelLayoutWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ProductLabelLayoutId")]
    [InverseProperty("ProductLabelLayouts")]
    public virtual ICollection<ProductProduct> ProductProducts { get; } = new List<ProductProduct>();

    [ForeignKey("ProductLabelLayoutId")]
    [InverseProperty("ProductLabelLayouts")]
    public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();

    [ForeignKey("ProductLabelLayoutId")]
    [InverseProperty("ProductLabelLayouts")]
    public virtual ICollection<StockMoveLine> StockMoveLines { get; } = new List<StockMoveLine>();
}
