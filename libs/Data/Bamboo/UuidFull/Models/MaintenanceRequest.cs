using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MaintenanceRequest
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? OwnerUserId { get; set; }

    public long? CategoryId { get; set; }

    public Guid? EquipmentId { get; set; }

    public Guid? UserId { get; set; }

    public long? StageId { get; set; }

    public long? Color { get; set; }

    public Guid? MaintenanceTeamId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

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

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? Duration { get; set; }

    public Guid? EmployeeId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual MaintenanceEquipment? Equipment { get; set; }

    public virtual MaintenanceTeam? MaintenanceTeam { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? OwnerUser { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
