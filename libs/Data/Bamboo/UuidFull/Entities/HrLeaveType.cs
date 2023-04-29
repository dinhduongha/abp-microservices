﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_leave_type")]
public partial class HrLeaveType
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("icon_id")]
    public Guid? IconId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("responsible_id")]
    public Guid? ResponsibleId { get; set; }

    [Column("leave_notif_subtype_id")]
    public long? LeaveNotifSubtypeId { get; set; }

    [Column("allocation_notif_subtype_id")]
    public long? AllocationNotifSubtypeId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("color_name")]
    public string? ColorName { get; set; }

    [Column("leave_validation_type")]
    public string? LeaveValidationType { get; set; }

    [Column("requires_allocation")]
    public string? RequiresAllocation { get; set; }

    [Column("employee_requests")]
    public string? EmployeeRequests { get; set; }

    [Column("allocation_validation_type")]
    public string? AllocationValidationType { get; set; }

    [Column("time_type")]
    public string? TimeType { get; set; }

    [Column("request_unit")]
    public string? RequestUnit { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("create_calendar_meeting")]
    public bool? CreateCalendarMeeting { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("unpaid")]
    public bool? Unpaid { get; set; }

    [Column("support_document")]
    public bool? SupportDocument { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("overtime_deductible")]
    public bool? OvertimeDeductible { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("HrLeaveTypes")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrLeaveTypeCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("IconId")]
    [InverseProperty("HrLeaveTypes")]
    public virtual IrAttachment? Icon { get; set; }

    [ForeignKey("ResponsibleId")]
    [InverseProperty("HrLeaveTypeResponsibles")]
    public virtual ResUser? Responsible { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrLeaveTypeWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
