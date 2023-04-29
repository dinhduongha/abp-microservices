using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class BaseImportTestsModelsFloat
{
    public Guid Id { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public decimal? Value2 { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? Value { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
