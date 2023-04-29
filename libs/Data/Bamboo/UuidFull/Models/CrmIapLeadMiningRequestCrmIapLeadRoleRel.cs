using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class CrmIapLeadMiningRequestCrmIapLeadRoleRel
{
    public Guid CrmIapLeadMiningRequestId { get; set; }

    public long CrmIapLeadRoleId { get; set; }

    public virtual CrmIapLeadMiningRequest CrmIapLeadMiningRequest { get; set; } = null!;
}
