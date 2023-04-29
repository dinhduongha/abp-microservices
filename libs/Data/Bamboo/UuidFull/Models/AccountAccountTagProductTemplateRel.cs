using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountAccountTagProductTemplateRel
{
    public Guid ProductTemplateId { get; set; }

    public long AccountAccountTagId { get; set; }

    public virtual ProductTemplate ProductTemplate { get; set; } = null!;
}
