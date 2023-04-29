using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class FleetServiceTypeFleetVehicleLogContractRel
{
    public Guid FleetVehicleLogContractId { get; set; }

    public long FleetServiceTypeId { get; set; }

    public virtual FleetVehicleLogContract FleetVehicleLogContract { get; set; } = null!;
}
