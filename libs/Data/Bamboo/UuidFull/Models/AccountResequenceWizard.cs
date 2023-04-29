using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountResequenceWizard
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? FirstName { get; set; }

    public string? Ordering { get; set; }

    public DateOnly? FirstDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();
}
