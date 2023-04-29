using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountMoveReversal
{
    public Guid Id { get; set; }

    public Guid? JournalId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? DateMode { get; set; }

    public string? Reason { get; set; }

    public string? RefundMethod { get; set; }

    public DateOnly? Date { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountMove> Moves { get; } = new List<AccountMove>();

    public virtual ICollection<AccountMove> NewMoves { get; } = new List<AccountMove>();
}
