using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountFiscalPositionResCountryStateRel
{
    public Guid AccountFiscalPositionId { get; set; }

    public long ResCountryStateId { get; set; }

    public virtual AccountFiscalPosition AccountFiscalPosition { get; set; } = null!;
}
