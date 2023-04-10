using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountTaxRepartitionLine
{
    public Guid Id { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? InvoiceTaxId { get; set; }

    public Guid? RefundTaxId { get; set; }

    public Guid? TenantId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? RepartitionType { get; set; }

    public bool? UseInTaxClosing { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? FactorPercent { get; set; }

    public virtual AccountAccount? Account { get; set; }

    //public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountTax? InvoiceTax { get; set; }

    public virtual AccountTax? RefundTax { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountAccountTag> AccountAccountTags { get; } = new List<AccountAccountTag>();
}
