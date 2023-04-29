using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockTrackConfirmation
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<StockTrackLine> StockTrackLines { get; } = new List<StockTrackLine>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProductProduct> ProductProducts { get; } = new List<ProductProduct>();

    public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();
}
