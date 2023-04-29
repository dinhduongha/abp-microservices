using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mrp_consumption_warning")]
public partial class MrpConsumptionWarning
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
    [InverseProperty("MrpConsumptionWarningCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("MrpConsumptionWarning")]
    public virtual ICollection<MrpConsumptionWarningLine> MrpConsumptionWarningLines { get; } = new List<MrpConsumptionWarningLine>();

    [ForeignKey("WriteUid")]
    [InverseProperty("MrpConsumptionWarningWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("MrpConsumptionWarningId")]
    [InverseProperty("MrpConsumptionWarnings")]
    public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();
}
