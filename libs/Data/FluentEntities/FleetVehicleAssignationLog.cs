using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class FleetVehicleAssignationLog
{
    public Guid Id { get; set; }

    public Guid? VehicleId { get; set; }

    public Guid? DriverId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateOnly? DateStart { get; set; }

    public DateOnly? DateEnd { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? DriverEmployeeId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Driver { get; set; }

    public virtual HrEmployee? DriverEmployee { get; set; }

    public virtual FleetVehicle? Vehicle { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
