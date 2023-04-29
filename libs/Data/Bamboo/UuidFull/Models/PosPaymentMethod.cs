using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class PosPaymentMethod
{
    public Guid Id { get; set; }

    public Guid? OutstandingAccountId { get; set; }

    public Guid? ReceivableAccountId { get; set; }

    public Guid? JournalId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? UsePaymentTerminal { get; set; }

    public string? Name { get; set; }

    public bool? IsCashCount { get; set; }

    public bool? SplitTransactions { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual AccountAccount? OutstandingAccount { get; set; }

    public virtual AccountAccount? ReceivableAccount { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
