using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockPackageTypeStockPutawayRuleRel
{
    public Guid StockPutawayRuleId { get; set; }

    public long StockPackageTypeId { get; set; }

    public virtual StockPutawayRule StockPutawayRule { get; set; } = null!;
}
