using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class CrmIapLeadMiningRequestResCountryRel
{
    public Guid CrmIapLeadMiningRequestId { get; set; }

    public long ResCountryId { get; set; }

    public virtual CrmIapLeadMiningRequest CrmIapLeadMiningRequest { get; set; } = null!;
}
