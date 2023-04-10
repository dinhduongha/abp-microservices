using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class StockReturnPickingLine
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? WizardId { get; set; }

    public Guid? MoveId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public decimal? Quantity { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public bool? ToRefund { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockMove? Move { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual StockReturnPicking? Wizard { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
