using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountAssetDepreciationLine
{
    public Guid Id { get; set; }

    public Guid? Sequence { get; set; }

    public Guid? AssetId { get; set; }

    public Guid? MoveId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public DateOnly? DepreciationDate { get; set; }

    public decimal? Amount { get; set; }

    public decimal? RemainingValue { get; set; }

    public decimal? DepreciatedValue { get; set; }

    public bool? MoveCheck { get; set; }

    public bool? MovePostedCheck { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual AccountAssetAsset? Asset { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountMove? Move { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
