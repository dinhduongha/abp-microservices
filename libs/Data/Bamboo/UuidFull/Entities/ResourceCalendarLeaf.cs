using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("resource_calendar_leaves")]
[Index("CalendarId", Name = "resource_calendar_leaves_calendar_id_index")]
[Index("ResourceId", Name = "resource_calendar_leaves_resource_id_index")]
public partial class ResourceCalendarLeaf
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("calendar_id")]
    public Guid? CalendarId { get; set; }

    [Column("resource_id")]
    public Guid? ResourceId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("time_type")]
    public string? TimeType { get; set; }

    [Column("date_from", TypeName = "timestamp without time zone")]
    public DateTime? DateFrom { get; set; }

    [Column("date_to", TypeName = "timestamp without time zone")]
    public DateTime? DateTo { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("holiday_id")]
    public Guid? HolidayId { get; set; }

    [ForeignKey("CalendarId")]
    [InverseProperty("ResourceCalendarLeaves")]
    public virtual ResourceCalendar? Calendar { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("ResourceCalendarLeaves")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ResourceCalendarLeafCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("HolidayId")]
    [InverseProperty("ResourceCalendarLeaves")]
    public virtual HrLeave? Holiday { get; set; }

    [InverseProperty("Leave")]
    public virtual ICollection<MrpWorkorder> MrpWorkorders { get; } = new List<MrpWorkorder>();

    [ForeignKey("ResourceId")]
    [InverseProperty("ResourceCalendarLeaves")]
    public virtual ResourceResource? Resource { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ResourceCalendarLeafWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
