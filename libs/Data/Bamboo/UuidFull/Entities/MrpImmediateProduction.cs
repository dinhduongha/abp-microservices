using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mrp_immediate_production")]
public partial class MrpImmediateProduction
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
    [InverseProperty("MrpImmediateProductionCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("ImmediateProduction")]
    public virtual ICollection<MrpImmediateProductionLine> MrpImmediateProductionLines { get; } = new List<MrpImmediateProductionLine>();

    [ForeignKey("WriteUid")]
    [InverseProperty("MrpImmediateProductionWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("MrpImmediateProductionId")]
    [InverseProperty("MrpImmediateProductions")]
    public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();
}
