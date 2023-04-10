using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class PosCloseSessionWizard
{
    public Guid Id { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Message { get; set; }

    public bool? AccountReadonly { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? AmountToBalance { get; set; }

    public virtual AccountAccount? Account { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
