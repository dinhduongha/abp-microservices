using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountBudgetPost
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<CrossoveredBudgetLine> CrossoveredBudgetLines { get; } = new List<CrossoveredBudgetLine>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountAccount> Accounts { get; } = new List<AccountAccount>();
}
