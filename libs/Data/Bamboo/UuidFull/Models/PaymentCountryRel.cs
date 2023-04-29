using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class PaymentCountryRel
{
    public Guid PaymentId { get; set; }

    public long CountryId { get; set; }

    public virtual PaymentProvider Payment { get; set; } = null!;
}
