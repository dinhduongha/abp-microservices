﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrSequence
{
    public Guid Id { get; set; }

    public long? NumberNext { get; set; }

    public long? NumberIncrement { get; set; }

    public long? Padding { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? Implementation { get; set; }

    public string? Prefix { get; set; }

    public string? Suffix { get; set; }

    public bool? Active { get; set; }

    public bool? UseDateRange { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<IrSequenceDateRange> IrSequenceDateRanges { get; } = new List<IrSequenceDateRange>();

    //public virtual ICollection<PosConfig> PosConfigSequenceLines { get; } = new List<PosConfig>();

    //public virtual ICollection<PosConfig> PosConfigSequences { get; } = new List<PosConfig>();

    //public virtual ICollection<StockPickingType> StockPickingTypes { get; } = new List<StockPickingType>();

    public virtual ResUser? WriteU { get; set; }
}