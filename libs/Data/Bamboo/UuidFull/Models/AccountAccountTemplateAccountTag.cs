using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountAccountTemplateAccountTag
{
    public Guid AccountAccountTemplateId { get; set; }

    public long AccountAccountTagId { get; set; }

    public virtual AccountAccountTemplate AccountAccountTemplate { get; set; } = null!;
}
