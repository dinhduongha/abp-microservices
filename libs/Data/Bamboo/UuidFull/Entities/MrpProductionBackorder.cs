using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mrp_production_backorder")]
public partial class MrpProductionBackorder
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
    [InverseProperty("MrpProductionBackorderCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("MrpProductionBackorder")]
    public virtual ICollection<MrpProductionBackorderLine> MrpProductionBackorderLines { get; } = new List<MrpProductionBackorderLine>();

    [ForeignKey("WriteUid")]
    [InverseProperty("MrpProductionBackorderWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("MrpProductionBackorderId")]
    [InverseProperty("MrpProductionBackorders")]
    public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();
}
