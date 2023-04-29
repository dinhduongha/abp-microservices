using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class RepairOrderRepairTagsRel
{
    public Guid RepairOrderId { get; set; }

    public long RepairTagsId { get; set; }

    public virtual RepairOrder RepairOrder { get; set; } = null!;
}
