using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MaintenanceRequest
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? OwnerUserId { get; set; }

    public long? CategoryId { get; set; }

    public Guid? EquipmentId { get; set; }

    public Guid? UserId { get; set; }

    public long? StageId { get; set; }

    public long? Color { get; set; }

    public Guid? MaintenanceTeamId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? EmailCc { get; set; }

    public string? Name { get; set; }

    public string? Priority { get; set; }

    public string? KanbanState { get; set; }

    public string? MaintenanceType { get; set; }

    public DateOnly? RequestDate { get; set; }

    public DateOnly? CloseDate { get; set; }

    public string? Description { get; set; }

    public bool? Archive { get; set; }

    public DateTime? ScheduleDate { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? Duration { get; set; }

    public Guid? EmployeeId { get; set; }

    public virtual MaintenanceEquipmentCategory? Category { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual MaintenanceEquipment? Equipment { get; set; }

    public virtual MaintenanceTeam? MaintenanceTeam { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? OwnerUser { get; set; }

    public virtual MaintenanceStage? Stage { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
