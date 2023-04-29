using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class UtmTagRel
{
    public Guid TagId { get; set; }

    public long CampaignId { get; set; }

    public virtual UtmCampaign Tag { get; set; } = null!;
}
