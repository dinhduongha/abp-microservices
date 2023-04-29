using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ResCountryGroupPricelistRel
{
    public Guid PricelistId { get; set; }

    public long ResCountryGroupId { get; set; }

    public virtual ProductPricelist Pricelist { get; set; } = null!;
}
