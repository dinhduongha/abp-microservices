using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("change_production_qty")]
public partial class ChangeProductionQty
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("mo_id")]
    public Guid? MoId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("product_qty")]
    public decimal? ProductQty { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ChangeProductionQtyCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MoId")]
    [InverseProperty("ChangeProductionQties")]
    public virtual MrpProduction? Mo { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ChangeProductionQtyWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
