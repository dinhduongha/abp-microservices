using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProductCategory
{
    public Guid Id { get; set; }

    public long? ParentId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? CompleteName { get; set; }

    public string? ParentPath { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? RemovalStrategyId { get; set; }

    public string? PackagingReserveMethod { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductRemoval? RemovalStrategy { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
