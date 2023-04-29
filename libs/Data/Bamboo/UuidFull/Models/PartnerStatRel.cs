using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class PartnerStatRel
{
    public Guid OsvMemoryId { get; set; }

    public Guid PartnerId { get; set; }

    public virtual FollowupPrint OsvMemory { get; set; } = null!;
}
