using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountBudgetPost
{
    public Guid Id { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrossoveredBudgetLine> CrossoveredBudgetLines { get; } = new List<CrossoveredBudgetLine>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountAccount> Accounts { get; } = new List<AccountAccount>();
}
