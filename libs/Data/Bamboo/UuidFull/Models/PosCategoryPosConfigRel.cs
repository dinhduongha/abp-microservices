using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class PosCategoryPosConfigRel
{
    public Guid PosConfigId { get; set; }

    public long PosCategoryId { get; set; }

    public virtual PosConfig PosConfig { get; set; } = null!;
}
