using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountReconcileModelResPartnerCategoryRel
{
    public Guid AccountReconcileModelId { get; set; }

    public long ResPartnerCategoryId { get; set; }

    public virtual AccountReconcileModel AccountReconcileModel { get; set; } = null!;
}
