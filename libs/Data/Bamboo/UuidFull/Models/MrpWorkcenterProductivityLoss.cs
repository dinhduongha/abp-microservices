using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MrpWorkcenterProductivityLoss
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public long? LossId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? LossType { get; set; }

    public bool? Manual { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivities { get; } = new List<MrpWorkcenterProductivity>();

    public virtual ResUser? WriteU { get; set; }
}
