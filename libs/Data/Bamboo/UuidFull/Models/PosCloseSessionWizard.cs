using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class PosCloseSessionWizard
{
    public Guid Id { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Message { get; set; }

    public bool? AccountReadonly { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? AmountToBalance { get; set; }

    public virtual AccountAccount? Account { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
