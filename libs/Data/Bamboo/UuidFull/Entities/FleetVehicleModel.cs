using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("fleet_vehicle_model")]
public partial class FleetVehicleModel
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("brand_id")]
    public long BrandId { get; set; }

    [Column("category_id")]
    public long? CategoryId { get; set; }

    [Column("model_year")]
    public long? ModelYear { get; set; }

    [Column("seats")]
    public long? Seats { get; set; }

    [Column("doors")]
    public long? Doors { get; set; }

    [Column("power")]
    public long? Power { get; set; }

    [Column("horsepower")]
    public long? Horsepower { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("vehicle_type")]
    public string? VehicleType { get; set; }

    [Column("transmission")]
    public string? Transmission { get; set; }

    [Column("color")]
    public string? Color { get; set; }

    [Column("co2_standard")]
    public string? Co2Standard { get; set; }

    [Column("default_fuel_type")]
    public string? DefaultFuelType { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("trailer_hook")]
    public bool? TrailerHook { get; set; }

    [Column("electric_assistance")]
    public bool? ElectricAssistance { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("default_co2")]
    public double? DefaultCo2 { get; set; }

    [Column("horsepower_tax")]
    public double? HorsepowerTax { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("FleetVehicleModelCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Model")]
    public virtual ICollection<FleetVehicle> FleetVehicles { get; } = new List<FleetVehicle>();

    [ForeignKey("WriteUid")]
    [InverseProperty("FleetVehicleModelWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ModelId")]
    [InverseProperty("Models")]
    public virtual ICollection<ResPartner> Partners { get; } = new List<ResPartner>();
}
