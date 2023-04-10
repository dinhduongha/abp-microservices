using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MrpWorkcenterProductivityLoss
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public long? LossId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? LossType { get; set; }

    public bool? Manual { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpWorkcenterProductivityLossType? Loss { get; set; }

    //public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivities { get; } = new List<MrpWorkcenterProductivity>();

    public virtual ResUser? WriteU { get; set; }
}
