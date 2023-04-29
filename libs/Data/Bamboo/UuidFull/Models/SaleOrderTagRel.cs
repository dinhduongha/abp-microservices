using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class SaleOrderTagRel
{
    public Guid OrderId { get; set; }

    public long TagId { get; set; }

    public virtual SaleOrder Order { get; set; } = null!;
}
