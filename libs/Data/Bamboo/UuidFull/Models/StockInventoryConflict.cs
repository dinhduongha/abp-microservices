using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockInventoryConflict
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();

    public virtual ICollection<StockQuant> StockQuantsNavigation { get; } = new List<StockQuant>();
}
