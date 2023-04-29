﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_contract")]
[Index("DateStart", Name = "hr_contract_date_start_index")]
[Index("ResourceCalendarId", Name = "hr_contract_resource_calendar_id_index")]
public partial class HrContract
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("structure_type_id")]
    public long? StructureTypeId { get; set; }

    [Column("employee_id")]
    public Guid? EmployeeId { get; set; }

    [Column("department_id")]
    public Guid? DepartmentId { get; set; }

    [Column("job_id")]
    public Guid? JobId { get; set; }

    [Column("resource_calendar_id")]
    public Guid? ResourceCalendarId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("contract_type_id")]
    public long? ContractTypeId { get; set; }

    [Column("hr_responsible_id")]
    public Guid? HrResponsibleId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("kanban_state")]
    public string? KanbanState { get; set; }

    [Column("date_start")]
    public DateOnly? DateStart { get; set; }

    [Column("date_end")]
    public DateOnly? DateEnd { get; set; }

    [Column("trial_date_end")]
    public DateOnly? TrialDateEnd { get; set; }

    [Column("notes")]
    public string? Notes { get; set; }

    [Column("wage")]
    public decimal? Wage { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("HrContracts")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrContractCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("HrContracts")]
    public virtual HrDepartment? Department { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("HrContracts")]
    public virtual HrEmployee? Employee { get; set; }

    [InverseProperty("Contract")]
    public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    [ForeignKey("HrResponsibleId")]
    [InverseProperty("HrContractHrResponsibles")]
    public virtual ResUser? HrResponsible { get; set; }

    [ForeignKey("JobId")]
    [InverseProperty("HrContracts")]
    public virtual HrJob? Job { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("HrContracts")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("ResourceCalendarId")]
    [InverseProperty("HrContracts")]
    public virtual ResourceCalendar? ResourceCalendar { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrContractWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
