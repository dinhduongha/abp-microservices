using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class CrmTagRel
{
    public Guid LeadId { get; set; }

    public long TagId { get; set; }

    public virtual CrmLead Lead { get; set; } = null!;
}
