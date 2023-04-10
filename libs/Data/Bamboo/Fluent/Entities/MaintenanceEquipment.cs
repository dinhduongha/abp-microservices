using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MaintenanceEquipment
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? TechnicianUserId { get; set; }

    public Guid? OwnerUserId { get; set; }

    public long? CategoryId { get; set; }

    public Guid? PartnerId { get; set; }

    public long? Color { get; set; }

    public long? MaintenanceCount { get; set; }

    public long? MaintenanceOpenCount { get; set; }

    public long? Period { get; set; }

    public Guid? MaintenanceTeamId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? PartnerRef { get; set; }

    public string? Location { get; set; }

    public string? Model { get; set; }

    public string? SerialNo { get; set; }

    public DateOnly? AssignDate { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    public DateOnly? WarrantyDate { get; set; }

    public DateOnly? ScrapDate { get; set; }

    public DateOnly? NextActionDate { get; set; }

    public string? Name { get; set; }

    public string? Note { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? Cost { get; set; }

    public double? MaintenanceDuration { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? DepartmentId { get; set; }

    public string? EquipmentAssignTo { get; set; }

    public virtual MaintenanceEquipmentCategory? Category { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    //public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; } = new List<MaintenanceRequest>();

    public virtual MaintenanceTeam? MaintenanceTeam { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? OwnerUser { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUser? TechnicianUser { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
