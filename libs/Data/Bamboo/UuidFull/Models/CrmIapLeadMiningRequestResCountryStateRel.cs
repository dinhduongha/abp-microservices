using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class CrmIapLeadMiningRequestResCountryStateRel
{
    public Guid CrmIapLeadMiningRequestId { get; set; }

    public long ResCountryStateId { get; set; }

    public virtual CrmIapLeadMiningRequest CrmIapLeadMiningRequest { get; set; } = null!;
}
