using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("picking_label_type")]
public partial class PickingLabelType
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("label_type")]
    public string? LabelType { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("PickingLabelTypeCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("PickingLabelTypeWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("PickingLabelTypeId")]
    [InverseProperty("PickingLabelTypes")]
    public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();
}
