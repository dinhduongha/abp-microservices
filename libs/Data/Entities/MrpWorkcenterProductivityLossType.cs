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

[Table("mrp_workcenter_productivity_loss_type")]
public partial class MrpWorkcenterProductivityLossType
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("loss_type")]
    public string? LossType { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("MrpWorkcenterProductivityLossTypeCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Loss")]
    public virtual ICollection<MrpWorkcenterProductivityLoss> MrpWorkcenterProductivityLosses { get; } = new List<MrpWorkcenterProductivityLoss>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("MrpWorkcenterProductivityLossTypeWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
