using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class CrmIapLeadIndustryCrmIapLeadMiningRequestRel
{
    public Guid CrmIapLeadMiningRequestId { get; set; }

    public long CrmIapLeadIndustryId { get; set; }

    public virtual CrmIapLeadMiningRequest CrmIapLeadMiningRequest { get; set; } = null!;
}
