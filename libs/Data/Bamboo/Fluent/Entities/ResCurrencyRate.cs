using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ResCurrencyRate
{
    public Guid Id { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateOnly? Name { get; set; }

    public decimal? Rate { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
