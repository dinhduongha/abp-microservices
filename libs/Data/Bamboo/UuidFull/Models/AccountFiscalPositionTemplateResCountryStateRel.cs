using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountFiscalPositionTemplateResCountryStateRel
{
    public Guid AccountFiscalPositionTemplateId { get; set; }

    public long ResCountryStateId { get; set; }

    public virtual AccountFiscalPositionTemplate AccountFiscalPositionTemplate { get; set; } = null!;
}
