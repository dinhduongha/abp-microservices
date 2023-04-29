using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountCashbookReport
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? TargetMove { get; set; }

    public string? DisplayAccount { get; set; }

    public string? Sortby { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateOnly? DateTo { get; set; }

    public bool? InitialBalance { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    public virtual ICollection<AccountAccount> Accounts { get; } = new List<AccountAccount>();
}
