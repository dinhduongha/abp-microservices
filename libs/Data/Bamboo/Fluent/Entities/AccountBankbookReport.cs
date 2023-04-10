using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountBankbookReport
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? TargetMove { get; set; }

    public string? DisplayAccount { get; set; }

    public string? Sortby { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateOnly? DateTo { get; set; }

    public bool? InitialBalance { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    //public virtual ICollection<AccountAccount> Accounts { get; } = new List<AccountAccount>();
}
