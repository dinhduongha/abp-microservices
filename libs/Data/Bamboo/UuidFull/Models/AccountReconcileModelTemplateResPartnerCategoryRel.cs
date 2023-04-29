using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountReconcileModelTemplateResPartnerCategoryRel
{
    public Guid AccountReconcileModelTemplateId { get; set; }

    public long ResPartnerCategoryId { get; set; }

    public virtual AccountReconcileModelTemplate AccountReconcileModelTemplate { get; set; } = null!;
}
