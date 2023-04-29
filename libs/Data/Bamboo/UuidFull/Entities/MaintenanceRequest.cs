using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("maintenance_request")]
[Index("EquipmentId", Name = "maintenance_request_equipment_id_index")]
public partial class MaintenanceRequest
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("owner_user_id")]
    public Guid? OwnerUserId { get; set; }

    [Column("category_id")]
    public long? CategoryId { get; set; }

    [Column("equipment_id")]
    public Guid? EquipmentId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("stage_id")]
    public long? StageId { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("maintenance_team_id")]
    public Guid? MaintenanceTeamId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("email_cc")]
    public string? EmailCc { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("priority")]
    public string? Priority { get; set; }

    [Column("kanban_state")]
    public string? KanbanState { get; set; }

    [Column("maintenance_type")]
    public string? MaintenanceType { get; set; }

    [Column("request_date")]
    public DateOnly? RequestDate { get; set; }

    [Column("close_date")]
    public DateOnly? CloseDate { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("archive")]
    public bool? Archive { get; set; }

    [Column("schedule_date", TypeName = "timestamp without time zone")]
    public DateTime? ScheduleDate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("duration")]
    public double? Duration { get; set; }

    [Column("employee_id")]
    public Guid? EmployeeId { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("MaintenanceRequests")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MaintenanceRequestCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("MaintenanceRequests")]
    public virtual HrEmployee? Employee { get; set; }

    [ForeignKey("EquipmentId")]
    [InverseProperty("MaintenanceRequests")]
    public virtual MaintenanceEquipment? Equipment { get; set; }

    [ForeignKey("MaintenanceTeamId")]
    [InverseProperty("MaintenanceRequests")]
    public virtual MaintenanceTeam? MaintenanceTeam { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("MaintenanceRequests")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("OwnerUserId")]
    [InverseProperty("MaintenanceRequestOwnerUsers")]
    public virtual ResUser? OwnerUser { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("MaintenanceRequestUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MaintenanceRequestWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
