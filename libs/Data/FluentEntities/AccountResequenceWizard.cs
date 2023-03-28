using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountResequenceWizard
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? FirstName { get; set; }

    public string? Ordering { get; set; }

    public DateOnly? FirstDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();
}
