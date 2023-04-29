using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("resource_calendar")]
public partial class ResourceCalendar
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("tz")]
    public string? Tz { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("two_weeks_calendar")]
    public bool? TwoWeeksCalendar { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("hours_per_day")]
    public double? HoursPerDay { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("ResourceCalendars")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ResourceCalendarCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("ResourceCalendar")]
    public virtual ICollection<HrContract> HrContracts { get; } = new List<HrContract>();

    [InverseProperty("ResourceCalendar")]
    public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    [InverseProperty("ResourceCalendar")]
    public virtual ICollection<HrLeaveStressDay> HrLeaveStressDays { get; } = new List<HrLeaveStressDay>();

    [InverseProperty("DefaultResourceCalendar")]
    public virtual ICollection<HrPayrollStructureType> HrPayrollStructureTypes { get; } = new List<HrPayrollStructureType>();

    [InverseProperty("ResourceCalendar")]
    public virtual ICollection<MrpWorkcenter> MrpWorkcenters { get; } = new List<MrpWorkcenter>();

    [InverseProperty("ResourceCalendar")]
    public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    [InverseProperty("Calendar")]
    public virtual ICollection<ResourceCalendarAttendance> ResourceCalendarAttendances { get; } = new List<ResourceCalendarAttendance>();

    [InverseProperty("Calendar")]
    public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeaves { get; } = new List<ResourceCalendarLeaf>();

    [InverseProperty("Calendar")]
    public virtual ICollection<ResourceResource> ResourceResources { get; } = new List<ResourceResource>();

    [ForeignKey("WriteUid")]
    [InverseProperty("ResourceCalendarWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
