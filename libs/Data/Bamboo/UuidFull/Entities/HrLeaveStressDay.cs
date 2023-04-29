using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_leave_stress_day")]
public partial class HrLeaveStressDay
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("resource_calendar_id")]
    public Guid? ResourceCalendarId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("start_date")]
    public DateOnly? StartDate { get; set; }

    [Column("end_date")]
    public DateOnly? EndDate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("HrLeaveStressDays")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrLeaveStressDayCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ResourceCalendarId")]
    [InverseProperty("HrLeaveStressDays")]
    public virtual ResourceCalendar? ResourceCalendar { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrLeaveStressDayWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("HrLeaveStressDayId")]
    [InverseProperty("HrLeaveStressDays")]
    public virtual ICollection<HrDepartment> HrDepartments { get; } = new List<HrDepartment>();
}
