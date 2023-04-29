using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mrp_production_backorder_line")]
public partial class MrpProductionBackorderLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("mrp_production_backorder_id")]
    public Guid? MrpProductionBackorderId { get; set; }

    [Column("mrp_production_id")]
    public Guid? MrpProductionId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("to_backorder")]
    public bool? ToBackorder { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MrpProductionBackorderLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MrpProductionId")]
    [InverseProperty("MrpProductionBackorderLines")]
    public virtual MrpProduction? MrpProduction { get; set; }

    [ForeignKey("MrpProductionBackorderId")]
    [InverseProperty("MrpProductionBackorderLines")]
    public virtual MrpProductionBackorder? MrpProductionBackorder { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MrpProductionBackorderLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
