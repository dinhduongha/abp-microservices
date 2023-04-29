using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountAccountTagAccountTaxRepartitionLineRel
{
    public Guid AccountTaxRepartitionLineId { get; set; }

    public long AccountAccountTagId { get; set; }

    public virtual AccountTaxRepartitionLine AccountTaxRepartitionLine { get; set; } = null!;
}
