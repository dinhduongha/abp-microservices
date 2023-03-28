using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class PaymentLinkWizard
{
    public Guid Id { get; set; }

    public Guid? ResId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? ResModel { get; set; }

    public string? Description { get; set; }

    public string? PaymentProviderSelection { get; set; }

    public decimal? Amount { get; set; }

    public decimal? AmountMax { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
