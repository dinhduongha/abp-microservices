﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("maintenance_request")]
[Index("EquipmentId", Name = "maintenance_request_equipment_id_index")]
public partial class MaintenanceRequest: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

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
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

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
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("duration")]
    public double? Duration { get; set; }

    [Column("employee_id")]
    public Guid? EmployeeId { get; set; }

    [ForeignKey("CategoryId")]
    //[InverseProperty("MaintenanceRequests")]
    public virtual MaintenanceEquipmentCategory? Category { get; set; }

    [ForeignKey("TenantId")]
    //[InverseProperty("MaintenanceRequests")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("MaintenanceRequestCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("EmployeeId")]
    //[InverseProperty("MaintenanceRequests")]
    public virtual HrEmployee? Employee { get; set; }

    [ForeignKey("EquipmentId")]
    //[InverseProperty("MaintenanceRequests")]
    public virtual MaintenanceEquipment? Equipment { get; set; }

    [ForeignKey("MaintenanceTeamId")]
    //[InverseProperty("MaintenanceRequests")]
    public virtual MaintenanceTeam? MaintenanceTeam { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    //[InverseProperty("MaintenanceRequests")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("OwnerUserId")]
    //[InverseProperty("MaintenanceRequestOwnerUsers")]
    public virtual ResUser? OwnerUser { get; set; }

    [ForeignKey("StageId")]
    //[InverseProperty("MaintenanceRequests")]
    public virtual MaintenanceStage? Stage { get; set; }

    [ForeignKey("UserId")]
    //[InverseProperty("MaintenanceRequestUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("MaintenanceRequestWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
