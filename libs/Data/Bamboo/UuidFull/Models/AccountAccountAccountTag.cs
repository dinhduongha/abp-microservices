using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountAccountAccountTag
{
    public Guid AccountAccountId { get; set; }

    public long AccountAccountTagId { get; set; }

    public virtual AccountAccount AccountAccount { get; set; } = null!;
}
