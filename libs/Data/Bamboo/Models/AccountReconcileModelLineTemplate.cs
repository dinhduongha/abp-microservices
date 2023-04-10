using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountReconcileModelLineTemplate
{
    public Guid Id { get; set; }

    public Guid? ModelId { get; set; }

    public long Sequence { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Label { get; set; }

    public string? AmountType { get; set; }

    public string? AmountString { get; set; }

    public bool? ForceTaxIncluded { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual AccountAccountTemplate? Account { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountReconcileModelTemplate? Model { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountTaxTemplate> AccountTaxTemplates { get; } = new List<AccountTaxTemplate>();
}
