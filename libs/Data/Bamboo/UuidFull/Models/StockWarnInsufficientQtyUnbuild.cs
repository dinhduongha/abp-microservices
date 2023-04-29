﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockWarnInsufficientQtyUnbuild
{
    public Guid Id { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? LocationId { get; set; }

    public Guid? UnbuildId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? ProductUomName { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? Quantity { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? Location { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual MrpUnbuild? Unbuild { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
