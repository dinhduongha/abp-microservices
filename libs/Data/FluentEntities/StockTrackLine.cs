using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockTrackLine
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? WizardId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual StockTrackConfirmation? Wizard { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
