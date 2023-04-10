using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class PosPaymentMethod
{
    public long Id { get; set; }

    public Guid? OutstandingAccountId { get; set; }

    public Guid? ReceivableAccountId { get; set; }

    public Guid? JournalId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? UsePaymentTerminal { get; set; }

    public string? Name { get; set; }

    public bool? IsCashCount { get; set; }

    public bool? SplitTransactions { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual AccountAccount? OutstandingAccount { get; set; }

    //public virtual ICollection<PosMakePayment> PosMakePayments { get; } = new List<PosMakePayment>();

    //public virtual ICollection<PosPayment> PosPayments { get; } = new List<PosPayment>();

    public virtual AccountAccount? ReceivableAccount { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();
}
