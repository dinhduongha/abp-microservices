using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("lot_label_layout")]
public partial class LotLabelLayout
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("label_quantity")]
    public string? LabelQuantity { get; set; }

    [Column("print_format")]
    public string? PrintFormat { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("LotLabelLayoutCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("LotLabelLayoutWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("LotLabelLayoutId")]
    [InverseProperty("LotLabelLayouts")]
    public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();
}
