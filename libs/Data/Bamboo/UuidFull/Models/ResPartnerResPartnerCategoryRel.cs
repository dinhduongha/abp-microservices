using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ResPartnerResPartnerCategoryRel
{
    public long CategoryId { get; set; }

    public Guid PartnerId { get; set; }

    public virtual ResPartner Partner { get; set; } = null!;
}
