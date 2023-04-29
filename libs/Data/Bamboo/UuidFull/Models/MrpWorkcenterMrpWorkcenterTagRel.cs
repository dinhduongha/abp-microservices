using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MrpWorkcenterMrpWorkcenterTagRel
{
    public Guid MrpWorkcenterId { get; set; }

    public long MrpWorkcenterTagId { get; set; }

    public virtual MrpWorkcenter MrpWorkcenter { get; set; } = null!;
}
