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

[Table("mrp_production_split_line")]
public partial class MrpProductionSplitLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("mrp_production_split_id")]
    public Guid? MrpProductionSplitId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("quantity")]
    public decimal? Quantity { get; set; }

    [Column("date", TypeName = "timestamp without time zone")]
    public DateTime? Date { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("MrpProductionSplitLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MrpProductionSplitId")]
    //[InverseProperty("MrpProductionSplitLines")]
    public virtual MrpProductionSplit? MrpProductionSplit { get; set; }

    [ForeignKey("UserId")]
    //[InverseProperty("MrpProductionSplitLineUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("MrpProductionSplitLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
