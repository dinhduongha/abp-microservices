using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ResCurrencyRate
{
    public Guid Id { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateOnly? Name { get; set; }

    public decimal? Rate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
