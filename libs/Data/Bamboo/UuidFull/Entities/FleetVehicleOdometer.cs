using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("fleet_vehicle_odometer")]
public partial class FleetVehicleOdometer
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("vehicle_id")]
    public Guid? VehicleId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("value")]
    public double? Value { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("FleetVehicleOdometerCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Odometer")]
    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServices { get; } = new List<FleetVehicleLogService>();

    [ForeignKey("VehicleId")]
    [InverseProperty("FleetVehicleOdometers")]
    public virtual FleetVehicle? Vehicle { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("FleetVehicleOdometerWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
