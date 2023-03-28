using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class BaseImportTestsModelsComplex
{
    public Guid Id { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? C { get; set; }

    public DateOnly? D { get; set; }

    public decimal? M { get; set; }

    public DateTime? Dt { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? F { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
