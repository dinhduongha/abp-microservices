using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

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
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("to_immediate")]
    public bool? ToImmediate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("MrpImmediateProductionLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ImmediateProductionId")]
    [InverseProperty("MrpImmediateProductionLines")]
    public virtual MrpImmediateProduction? ImmediateProduction { get; set; }

    [ForeignKey("ProductionId")]
    [InverseProperty("MrpImmediateProductionLines")]
    public virtual MrpProduction? Production { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("MrpImmediateProductionLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
