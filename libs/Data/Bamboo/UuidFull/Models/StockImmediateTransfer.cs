using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockImmediateTransfer
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public bool? ShowTransfers { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<StockImmediateTransferLine> StockImmediateTransferLines { get; } = new List<StockImmediateTransferLine>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();
}
