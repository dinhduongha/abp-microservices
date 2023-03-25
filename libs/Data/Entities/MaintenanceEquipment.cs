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

[Table("maintenance_equipment")]
[Index("SerialNo", Name = "maintenance_equipment_serial_no", IsUnique = true)]
public partial class MaintenanceEquipment: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("technician_user_id")]
    public Guid? TechnicianUserId { get; set; }

    [Column("owner_user_id")]
    public Guid? OwnerUserId { get; set; }

    [Column("category_id")]
    public long? CategoryId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("maintenance_count")]
    public long? MaintenanceCount { get; set; }

    [Column("maintenance_open_count")]
    public long? MaintenanceOpenCount { get; set; }

    [Column("period")]
    public long? Period { get; set; }

    [Column("maintenance_team_id")]
    public Guid? MaintenanceTeamId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("partner_ref")]
    public string? PartnerRef { get; set; }

    [Column("location")]
    public string? Location { get; set; }

    [Column("model")]
    public string? Model { get; set; }

    [Column("serial_no")]
    public string? SerialNo { get; set; }

    [Column("assign_date")]
    public DateOnly? AssignDate { get; set; }

    [Column("effective_date")]
    public DateOnly? EffectiveDate { get; set; }

    [Column("warranty_date")]
    public DateOnly? WarrantyDate { get; set; }

    [Column("scrap_date")]
    public DateOnly? ScrapDate { get; set; }

    [Column("next_action_date")]
    public DateOnly? NextActionDate { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("note")]
    public string? Note { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("cost")]
    public double? Cost { get; set; }

    [Column("maintenance_duration")]
    public double? MaintenanceDuration { get; set; }

    [Column("employee_id")]
    public Guid? EmployeeId { get; set; }

    [Column("department_id")]
    public Guid? DepartmentId { get; set; }

    [Column("equipment_assign_to")]
    public string? EquipmentAssignTo { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("MaintenanceEquipments")]
    public virtual MaintenanceEquipmentCategory? Category { get; set; }

    [ForeignKey("TenantId")]
    [InverseProperty("MaintenanceEquipments")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("MaintenanceEquipmentCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("MaintenanceEquipments")]
    public virtual HrDepartment? Department { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("MaintenanceEquipments")]
    public virtual HrEmployee? Employee { get; set; }

    [InverseProperty("Equipment")]
    [NotMapped]
    public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; } = new List<MaintenanceRequest>();

    [ForeignKey("MaintenanceTeamId")]
    [InverseProperty("MaintenanceEquipments")]
    public virtual MaintenanceTeam? MaintenanceTeam { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("MaintenanceEquipments")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("OwnerUserId")]
    [InverseProperty("MaintenanceEquipmentOwnerUsers")]
    public virtual ResUser? OwnerUser { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("MaintenanceEquipments")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("TechnicianUserId")]
    [InverseProperty("MaintenanceEquipmentTechnicianUsers")]
    public virtual ResUser? TechnicianUser { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("MaintenanceEquipmentWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
