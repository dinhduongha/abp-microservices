using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountGroup
{
    public Guid Id { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? ParentPath { get; set; }

    public string? Name { get; set; }

    public string? CodePrefixStart { get; set; }

    public string? CodePrefixEnd { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountAccount> AccountAccounts { get; } = new List<AccountAccount>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<AccountGroup> InverseParent { get; } = new List<AccountGroup>();

    public virtual AccountGroup? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
