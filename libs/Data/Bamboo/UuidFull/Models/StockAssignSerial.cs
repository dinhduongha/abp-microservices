using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockAssignSerial
{
    public Guid Id { get; set; }

    public Guid? MoveId { get; set; }

    public long? NextSerialCount { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? NextSerialNumber { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? ProductionId { get; set; }

    public string? SerialNumbers { get; set; }

    public string? MultipleLotComponentsNames { get; set; }

    public decimal? ExpectedQty { get; set; }

    public decimal? ProducedQty { get; set; }

    public bool? ShowApply { get; set; }

    public bool? ShowBackorders { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockMove? Move { get; set; }

    public virtual MrpProduction? Production { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
