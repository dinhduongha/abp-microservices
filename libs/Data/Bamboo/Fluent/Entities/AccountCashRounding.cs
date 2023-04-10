using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountCashRounding
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Strategy { get; set; }

    public string? RoundingMethod { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? Rounding { get; set; }

    //public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();

    public virtual ResUser? WriteU { get; set; }
}
