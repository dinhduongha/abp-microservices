using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountTaxRepartitionFinancialTag
{
    public Guid AccountTaxRepartitionLineTemplateId { get; set; }

    public long AccountAccountTagId { get; set; }

    public virtual AccountTaxRepartitionLineTemplate AccountTaxRepartitionLineTemplate { get; set; } = null!;
}
