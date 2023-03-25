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

[Table("mrp_consumption_warning")]
public partial class MrpConsumptionWarning
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("MrpConsumptionWarningCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("MrpConsumptionWarning")]
    public virtual ICollection<MrpConsumptionWarningLine> MrpConsumptionWarningLines { get; } = new List<MrpConsumptionWarningLine>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("MrpConsumptionWarningWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("MrpConsumptionWarningId")]
    [InverseProperty("MrpConsumptionWarnings")]
    public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();
}
