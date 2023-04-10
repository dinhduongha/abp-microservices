using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountMoveReversal
{
    public Guid Id { get; set; }

    public Guid? JournalId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? DateMode { get; set; }

    public string? Reason { get; set; }

    public string? RefundMethod { get; set; }

    public DateOnly? Date { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountMove> Moves { get; } = new List<AccountMove>();

    //public virtual ICollection<AccountMove> NewMoves { get; } = new List<AccountMove>();
}
