using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class BaseImportTestsModelsFloat
{
    public Guid Id { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public decimal? Value2 { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? Value { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
