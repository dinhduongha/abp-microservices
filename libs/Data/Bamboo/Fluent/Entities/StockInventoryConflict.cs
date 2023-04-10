using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockInventoryConflict
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();

    //public virtual ICollection<StockQuant> StockQuantsNavigation { get; } = new List<StockQuant>();
}
