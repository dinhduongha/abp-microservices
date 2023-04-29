using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class FleetVehicleVehicleTagRel
{
    public Guid VehicleTagId { get; set; }

    public long TagId { get; set; }

    public virtual FleetVehicle VehicleTag { get; set; } = null!;
}
