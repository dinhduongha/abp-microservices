using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mrp_immediate_production_line")]
public partial class MrpImmediateProductionLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("immediate_production_id")]
    public Guid? ImmediateProductionId { get; set; }

    [Column("production_id")]
    public Guid? ProductionId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("to_immediate")]
    public bool? ToImmediate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MrpImmediateProductionLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ImmediateProductionId")]
    [InverseProperty("MrpImmediateProductionLines")]
    public virtual MrpImmediateProduction? ImmediateProduction { get; set; }

    [ForeignKey("ProductionId")]
    [InverseProperty("MrpImmediateProductionLines")]
    public virtual MrpProduction? Production { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MrpImmediateProductionLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
