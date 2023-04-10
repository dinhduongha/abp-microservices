using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountReconcileModelPartnerMapping
{
    public Guid Id { get; set; }

    public Guid? ModelId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? PaymentRefRegex { get; set; }

    public string? NarrationRegex { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountReconcileModel? Model { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
