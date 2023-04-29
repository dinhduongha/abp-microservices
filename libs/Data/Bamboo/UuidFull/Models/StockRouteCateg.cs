using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockRouteCateg
{
    public Guid RouteId { get; set; }

    public long CategId { get; set; }

    public virtual StockRoute Route { get; set; } = null!;
}
