using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountGroup
{
    public Guid Id { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? ParentPath { get; set; }

    public string? Name { get; set; }

    public string? CodePrefixStart { get; set; }

    public string? CodePrefixEnd { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountAccount> AccountAccounts { get; } = new List<AccountAccount>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<AccountGroup> InverseParent { get; } = new List<AccountGroup>();

    public virtual AccountGroup? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
