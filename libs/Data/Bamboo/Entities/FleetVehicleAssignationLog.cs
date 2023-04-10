using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("fleet_vehicle_assignation_log")]
public partial class FleetVehicleAssignationLog
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("vehicle_id")]
    public Guid? VehicleId { get; set; }

    [Column("driver_id")]
    public Guid? DriverId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("date_start")]
    public DateOnly? DateStart { get; set; }

    [Column("date_end")]
    public DateOnly? DateEnd { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("driver_employee_id")]
    public Guid? DriverEmployeeId { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("FleetVehicleAssignationLogCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("DriverId")]
    //[InverseProperty("FleetVehicleAssignationLogs")]
    public virtual ResPartner? Driver { get; set; }

    [ForeignKey("DriverEmployeeId")]
    //[InverseProperty("FleetVehicleAssignationLogs")]
    public virtual HrEmployee? DriverEmployee { get; set; }

    [ForeignKey("VehicleId")]
    //[InverseProperty("FleetVehicleAssignationLogs")]
    public virtual FleetVehicle? Vehicle { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("FleetVehicleAssignationLogWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
