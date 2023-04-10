using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockTrackConfirmation
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<StockTrackLine> StockTrackLines { get; } = new List<StockTrackLine>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ProductProduct> ProductProducts { get; } = new List<ProductProduct>();

    //public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();
}
