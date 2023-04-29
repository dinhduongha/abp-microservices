using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountAccountTagAccountMoveLineRel
{
    public Guid AccountMoveLineId { get; set; }

    public long AccountAccountTagId { get; set; }

    public virtual AccountMoveLine AccountMoveLine { get; set; } = null!;
}
