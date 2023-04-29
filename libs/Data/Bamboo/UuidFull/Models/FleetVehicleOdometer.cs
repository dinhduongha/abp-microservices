using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class FleetVehicleOdometer
{
    public Guid Id { get; set; }

    public Guid? VehicleId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public DateOnly? Date { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? Value { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServices { get; } = new List<FleetVehicleLogService>();

    public virtual FleetVehicle? Vehicle { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
