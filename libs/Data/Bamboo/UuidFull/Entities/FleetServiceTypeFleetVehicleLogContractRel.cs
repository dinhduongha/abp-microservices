using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("FleetVehicleLogContractId", "FleetServiceTypeId")]
[Table("fleet_service_type_fleet_vehicle_log_contract_rel")]
[Index("FleetServiceTypeId", "FleetVehicleLogContractId", Name = "fleet_service_type_fleet_vehi_fleet_service_type_id_fleet_v_idx")]
public partial class FleetServiceTypeFleetVehicleLogContractRel
{
    [Key]
    [Column("fleet_vehicle_log_contract_id")]
    public Guid FleetVehicleLogContractId { get; set; }

    [Key]
    [Column("fleet_service_type_id")]
    public long FleetServiceTypeId { get; set; }

    [ForeignKey("FleetVehicleLogContractId")]
    [InverseProperty("FleetServiceTypeFleetVehicleLogContractRels")]
    public virtual FleetVehicleLogContract FleetVehicleLogContract { get; set; } = null!;
}
