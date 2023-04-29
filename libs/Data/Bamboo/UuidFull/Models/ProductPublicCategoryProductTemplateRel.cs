using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProductPublicCategoryProductTemplateRel
{
    public long ProductPublicCategoryId { get; set; }

    public Guid ProductTemplateId { get; set; }

    public virtual ProductTemplate ProductTemplate { get; set; } = null!;
}
