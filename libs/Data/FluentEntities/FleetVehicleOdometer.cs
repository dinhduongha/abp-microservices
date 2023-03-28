using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class FleetVehicleOdometer
{
    public Guid Id { get; set; }

    public Guid? VehicleId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public DateOnly? Date { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? Value { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServices { get; } = new List<FleetVehicleLogService>();

    public virtual FleetVehicle? Vehicle { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
