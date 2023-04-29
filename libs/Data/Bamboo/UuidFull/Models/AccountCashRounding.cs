using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountCashRounding
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Strategy { get; set; }

    public string? RoundingMethod { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? Rounding { get; set; }

    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();

    public virtual ResUser? WriteU { get; set; }
}
