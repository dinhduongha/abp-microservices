using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mrp_production_split")]
public partial class MrpProductionSplit
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("production_split_multi_id")]
    public Guid? ProductionSplitMultiId { get; set; }

    [Column("production_id")]
    public Guid? ProductionId { get; set; }

    [Column("counter")]
    public long? Counter { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MrpProductionSplitCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("MrpProductionSplit")]
    public virtual ICollection<MrpProductionSplitLine> MrpProductionSplitLines { get; } = new List<MrpProductionSplitLine>();

    [ForeignKey("ProductionId")]
    [InverseProperty("MrpProductionSplits")]
    public virtual MrpProduction? Production { get; set; }

    [ForeignKey("ProductionSplitMultiId")]
    [InverseProperty("MrpProductionSplits")]
    public virtual MrpProductionSplitMulti? ProductionSplitMulti { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MrpProductionSplitWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
