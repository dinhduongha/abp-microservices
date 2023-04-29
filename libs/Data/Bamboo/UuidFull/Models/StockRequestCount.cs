using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockRequestCount
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? SetCount { get; set; }

    public DateOnly? InventoryDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public DateOnly? AccountingDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();
}
