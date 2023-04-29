using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class FleetVehicleModel
{
    public Guid Id { get; set; }

    public long BrandId { get; set; }

    public long? CategoryId { get; set; }

    public long? ModelYear { get; set; }

    public long? Seats { get; set; }

    public long? Doors { get; set; }

    public long? Power { get; set; }

    public long? Horsepower { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? VehicleType { get; set; }

    public string? Transmission { get; set; }

    public string? Color { get; set; }

    public string? Co2Standard { get; set; }

    public string? DefaultFuelType { get; set; }

    public bool? Active { get; set; }

    public bool? TrailerHook { get; set; }

    public bool? ElectricAssistance { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? DefaultCo2 { get; set; }

    public double? HorsepowerTax { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<FleetVehicle> FleetVehicles { get; } = new List<FleetVehicle>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResPartner> Partners { get; } = new List<ResPartner>();
}
