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

[Table("mrp_production_split_multi")]
public partial class MrpProductionSplitMulti
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
    [InverseProperty("MrpProductionSplitMultiCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("ProductionSplitMulti")]
    public virtual ICollection<MrpProductionSplit> MrpProductionSplits { get; } = new List<MrpProductionSplit>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("MrpProductionSplitMultiWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
