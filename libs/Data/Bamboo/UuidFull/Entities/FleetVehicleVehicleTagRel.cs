using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("VehicleTagId", "TagId")]
[Table("fleet_vehicle_vehicle_tag_rel")]
[Index("TagId", "VehicleTagId", Name = "fleet_vehicle_vehicle_tag_rel_tag_id_vehicle_tag_id_idx")]
public partial class FleetVehicleVehicleTagRel
{
    [Key]
    [Column("vehicle_tag_id")]
    public Guid VehicleTagId { get; set; }

    [Key]
    [Column("tag_id")]
    public long TagId { get; set; }

    [ForeignKey("VehicleTagId")]
    [InverseProperty("FleetVehicleVehicleTagRels")]
    public virtual FleetVehicle VehicleTag { get; set; } = null!;
}
