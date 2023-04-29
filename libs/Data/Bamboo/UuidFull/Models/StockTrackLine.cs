using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockTrackLine
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? WizardId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual StockTrackConfirmation? Wizard { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
