using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mrp_production_split_line")]
public partial class MrpProductionSplitLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("mrp_production_split_id")]
    public Guid? MrpProductionSplitId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("quantity")]
    public decimal? Quantity { get; set; }

    [Column("date", TypeName = "timestamp without time zone")]
    public DateTime? Date { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MrpProductionSplitLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MrpProductionSplitId")]
    [InverseProperty("MrpProductionSplitLines")]
    public virtual MrpProductionSplit? MrpProductionSplit { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("MrpProductionSplitLineUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MrpProductionSplitLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
