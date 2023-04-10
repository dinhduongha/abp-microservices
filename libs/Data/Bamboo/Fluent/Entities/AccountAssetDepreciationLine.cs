using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountAssetDepreciationLine
{
    public Guid Id { get; set; }

    public Guid? Sequence { get; set; }

    public Guid? AssetId { get; set; }

    public Guid? MoveId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public DateOnly? DepreciationDate { get; set; }

    public decimal? Amount { get; set; }

    public decimal? RemainingValue { get; set; }

    public decimal? DepreciatedValue { get; set; }

    public bool? MoveCheck { get; set; }

    public bool? MovePostedCheck { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual AccountAssetAsset? Asset { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountMove? Move { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
