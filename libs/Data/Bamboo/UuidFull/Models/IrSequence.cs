using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class IrSequence
{
    public Guid Id { get; set; }

    public long? NumberNext { get; set; }

    public long? NumberIncrement { get; set; }

    public long? Padding { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? Implementation { get; set; }

    public string? Prefix { get; set; }

    public string? Suffix { get; set; }

    public bool? Active { get; set; }

    public bool? UseDateRange { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<IrSequenceDateRange> IrSequenceDateRanges { get; } = new List<IrSequenceDateRange>();

    public virtual ICollection<PosConfig> PosConfigSequenceLines { get; } = new List<PosConfig>();

    public virtual ICollection<PosConfig> PosConfigSequences { get; } = new List<PosConfig>();

    public virtual ICollection<StockPickingType> StockPickingTypes { get; } = new List<StockPickingType>();

    public virtual ResUser? WriteU { get; set; }
}
