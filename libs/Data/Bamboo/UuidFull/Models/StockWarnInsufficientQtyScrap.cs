﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockWarnInsufficientQtyScrap
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? LocationId { get; set; }

    public Guid? ScrapId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? ProductUomName { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? Quantity { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? Location { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual StockScrap? Scrap { get; set; }

    public virtual ResUser? WriteU { get; set; }
}