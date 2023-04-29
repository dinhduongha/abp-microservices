using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class FleetVehicleLogContract
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? VehicleId { get; set; }

    public long? CostSubtypeId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? InsurerId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? InsRef { get; set; }

    public string? State { get; set; }

    public string? CostFrequency { get; set; }

    public DateOnly? Date { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public string? Notes { get; set; }

    public decimal? Amount { get; set; }

    public decimal? CostGenerated { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<FleetServiceTypeFleetVehicleLogContractRel> FleetServiceTypeFleetVehicleLogContractRels { get; } = new List<FleetServiceTypeFleetVehicleLogContractRel>();

    public virtual ResPartner? Insurer { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual FleetVehicle? Vehicle { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
