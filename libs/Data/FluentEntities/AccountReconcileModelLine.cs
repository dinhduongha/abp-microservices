using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountReconcileModelLine
{
    public Guid Id { get; set; }

    public Guid? ModelId { get; set; }

    public Guid? TenantId { get; set; }

    public long Sequence { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? JournalId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Label { get; set; }

    public string? AmountType { get; set; }

    public string? AmountString { get; set; }

    public string? AnalyticDistribution { get; set; }

    public bool? ForceTaxIncluded { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? Amount { get; set; }

    public virtual AccountAccount? Account { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual AccountReconcileModel? Model { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();
}
