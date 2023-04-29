using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProductTagProductProductRel
{
    public Guid ProductProductId { get; set; }

    public long ProductTagId { get; set; }

    public virtual ProductProduct ProductProduct { get; set; } = null!;
}
