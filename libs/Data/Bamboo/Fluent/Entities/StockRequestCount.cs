using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockRequestCount
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? SetCount { get; set; }

    public DateOnly? InventoryDate { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public DateOnly? AccountingDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();
}
