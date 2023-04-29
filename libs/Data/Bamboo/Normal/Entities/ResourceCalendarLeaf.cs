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

[Table("resource_calendar_leaves")]
[Index("CalendarId", Name = "resource_calendar_leaves_calendar_id_index")]
[Index("ResourceId", Name = "resource_calendar_leaves_resource_id_index")]
public partial class ResourceCalendarLeaf: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("calendar_id")]
    public Guid? CalendarId { get; set; }

    [Column("resource_id")]
    public Guid? ResourceId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("time_type")]
    public string? TimeType { get; set; }

    [Column("date_from", TypeName = "timestamp without time zone")]
    public DateTime? DateFrom { get; set; }

    [Column("date_to", TypeName = "timestamp without time zone")]
    public DateTime? DateTo { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("holiday_id")]
    public Guid? HolidayId { get; set; }

    [ForeignKey("CalendarId")]
    //[InverseProperty("ResourceCalendarLeaves")]
    public virtual ResourceCalendar? Calendar { get; set; }

    [ForeignKey("TenantId")]
    //[InverseProperty("ResourceCalendarLeaves")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("ResourceCalendarLeafCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("HolidayId")]
    //[InverseProperty("ResourceCalendarLeaves")]
    public virtual HrLeave? Holiday { get; set; }

    [ForeignKey("ResourceId")]
    //[InverseProperty("ResourceCalendarLeaves")]
    public virtual ResourceResource? Resource { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("ResourceCalendarLeafWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("Leave")]
    [NotMapped]
    public virtual ICollection<MrpWorkorder> MrpWorkorders { get; } = new List<MrpWorkorder>();


}
