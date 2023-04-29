using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class PosConfigPosPaymentMethodRel
{
    public Guid PosConfigId { get; set; }

    public long PosPaymentMethodId { get; set; }

    public virtual PosConfig PosConfig { get; set; } = null!;
}
