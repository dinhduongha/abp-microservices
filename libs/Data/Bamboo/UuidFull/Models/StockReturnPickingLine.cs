﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockReturnPickingLine
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? WizardId { get; set; }

    public Guid? MoveId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public decimal? Quantity { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public bool? ToRefund { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockMove? Move { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual StockReturnPicking? Wizard { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
