using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class FleetVehicle
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? ManagerId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? DriverId { get; set; }

    public Guid? FutureDriverId { get; set; }

    public Guid? ModelId { get; set; }

    public long? BrandId { get; set; }

    public long? StateId { get; set; }

    public long? Seats { get; set; }

    public long? Doors { get; set; }

    public long? Horsepower { get; set; }

    public long? Power { get; set; }

    public long? CategoryId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? LicensePlate { get; set; }

    public string? VinSn { get; set; }

    public string? Color { get; set; }

    public string? Location { get; set; }

    public string? ModelYear { get; set; }

    public string? OdometerUnit { get; set; }

    public string? Transmission { get; set; }

    public string? FuelType { get; set; }

    public string? Co2Standard { get; set; }

    public string? FrameType { get; set; }

    public DateOnly? NextAssignationDate { get; set; }

    public DateOnly? AcquisitionDate { get; set; }

    public DateOnly? WriteOffDate { get; set; }

    public DateOnly? FirstContractDate { get; set; }

    public string? Description { get; set; }

    public bool? Active { get; set; }

    public bool? TrailerHook { get; set; }

    public bool? PlanToChangeCar { get; set; }

    public bool? PlanToChangeBike { get; set; }

    public bool? ElectricAssistance { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? HorsepowerTax { get; set; }

    public double? Co2 { get; set; }

    public double? CarValue { get; set; }

    public double? NetCarValue { get; set; }

    public double? ResidualValue { get; set; }

    public double? FrameSize { get; set; }

    public Guid? DriverEmployeeId { get; set; }

    public Guid? FutureDriverEmployeeId { get; set; }

    public string? MobilityCard { get; set; }

    //public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    public virtual FleetVehicleModelBrand? Brand { get; set; }

    public virtual FleetVehicleModelCategory? Category { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Driver { get; set; }

    public virtual HrEmployee? DriverEmployee { get; set; }

    //public virtual ICollection<FleetVehicleAssignationLog> FleetVehicleAssignationLogs { get; } = new List<FleetVehicleAssignationLog>();

    //public virtual ICollection<FleetVehicleLogContract> FleetVehicleLogContracts { get; } = new List<FleetVehicleLogContract>();

    //public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServices { get; } = new List<FleetVehicleLogService>();

    //public virtual ICollection<FleetVehicleOdometer> FleetVehicleOdometers { get; } = new List<FleetVehicleOdometer>();

    public virtual ResPartner? FutureDriver { get; set; }

    public virtual HrEmployee? FutureDriverEmployee { get; set; }

    public virtual ResUser? Manager { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual FleetVehicleModel? Model { get; set; }

    public virtual FleetVehicleState? State { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<FleetVehicleTag> Tags { get; } = new List<FleetVehicleTag>();
}
