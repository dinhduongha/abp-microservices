using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockImmediateTransfer
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? ShowTransfers { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<StockImmediateTransferLine> StockImmediateTransferLines { get; } = new List<StockImmediateTransferLine>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();
}
