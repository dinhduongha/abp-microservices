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

[Table("change_production_qty")]
public partial class ChangeProductionQty
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("mo_id")]
    public Guid? MoId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("product_qty")]
    public decimal? ProductQty { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("ChangeProductionQtyCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MoId")]
    //[InverseProperty("ChangeProductionQties")]
    public virtual MrpProduction? Mo { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("ChangeProductionQtyWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
