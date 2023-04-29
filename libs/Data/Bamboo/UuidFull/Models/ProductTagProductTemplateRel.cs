using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProductTagProductTemplateRel
{
    public Guid ProductTemplateId { get; set; }

    public long ProductTagId { get; set; }

    public virtual ProductTemplate ProductTemplate { get; set; } = null!;
}
