using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class CrmIapLeadMiningRequestCrmTagRel
{
    public Guid CrmIapLeadMiningRequestId { get; set; }

    public long CrmTagId { get; set; }

    public virtual CrmIapLeadMiningRequest CrmIapLeadMiningRequest { get; set; } = null!;
}
