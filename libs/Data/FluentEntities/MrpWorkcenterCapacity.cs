using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MrpWorkcenterCapacity
{
    public Guid Id { get; set; }

    public Guid? WorkcenterId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? Capacity { get; set; }

    public double? TimeStart { get; set; }

    public double? TimeStop { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual MrpWorkcenter? Workcenter { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
