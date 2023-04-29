using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mrp_production_split_multi")]
public partial class MrpProductionSplitMulti
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MrpProductionSplitMultiCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("ProductionSplitMulti")]
    public virtual ICollection<MrpProductionSplit> MrpProductionSplits { get; } = new List<MrpProductionSplit>();

    [ForeignKey("WriteUid")]
    [InverseProperty("MrpProductionSplitMultiWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
