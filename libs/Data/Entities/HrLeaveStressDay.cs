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

[Table("hr_leave_stress_day")]
public partial class HrLeaveStressDay: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("color")]
    public Guid? Color { get; set; }

    [Column("resource_calendar_id")]
    public Guid? ResourceCalendarId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("start_date")]
    public DateOnly? StartDate { get; set; }

    [Column("end_date")]
    public DateOnly? EndDate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("TenantId")]
    [InverseProperty("HrLeaveStressDays")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("HrLeaveStressDayCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ResourceCalendarId")]
    [InverseProperty("HrLeaveStressDays")]
    public virtual ResourceCalendar? ResourceCalendar { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("HrLeaveStressDayWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("HrLeaveStressDayId")]
    [InverseProperty("HrLeaveStressDays")]
    public virtual ICollection<HrDepartment> HrDepartments { get; } = new List<HrDepartment>();
}
