using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("resource_resource")]
public partial class ResourceResource
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("calendar_id")]
    public Guid? CalendarId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("resource_type")]
    public string? ResourceType { get; set; }

    [Column("tz")]
    public string? Tz { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("time_efficiency")]
    public double? TimeEfficiency { get; set; }

    [ForeignKey("CalendarId")]
    [InverseProperty("ResourceResources")]
    public virtual ResourceCalendar? Calendar { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("ResourceResources")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ResourceResourceCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Resource")]
    public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    [InverseProperty("Resource")]
    public virtual ICollection<MrpWorkcenter> MrpWorkcenters { get; } = new List<MrpWorkcenter>();

    [InverseProperty("Resource")]
    public virtual ICollection<ResourceCalendarAttendance> ResourceCalendarAttendances { get; } = new List<ResourceCalendarAttendance>();

    [InverseProperty("Resource")]
    public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeaves { get; } = new List<ResourceCalendarLeaf>();

    [ForeignKey("UserId")]
    [InverseProperty("ResourceResourceUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ResourceResourceWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
