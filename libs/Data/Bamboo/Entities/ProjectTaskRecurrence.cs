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

[Table("project_task_recurrence")]
public partial class ProjectTaskRecurrence
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("recurrence_left")]
    public long? RecurrenceLeft { get; set; }

    [Column("repeat_interval")]
    public long? RepeatInterval { get; set; }

    [Column("repeat_number")]
    public long? RepeatNumber { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("repeat_unit")]
    public string? RepeatUnit { get; set; }

    [Column("repeat_type")]
    public string? RepeatType { get; set; }

    [Column("repeat_on_month")]
    public string? RepeatOnMonth { get; set; }

    [Column("repeat_on_year")]
    public string? RepeatOnYear { get; set; }

    [Column("repeat_day")]
    public string? RepeatDay { get; set; }

    [Column("repeat_week")]
    public string? RepeatWeek { get; set; }

    [Column("repeat_weekday")]
    public string? RepeatWeekday { get; set; }

    [Column("repeat_month")]
    public string? RepeatMonth { get; set; }

    [Column("next_recurrence_date")]
    public DateOnly? NextRecurrenceDate { get; set; }

    [Column("repeat_until")]
    public DateOnly? RepeatUntil { get; set; }

    [Column("mon")]
    public bool? Mon { get; set; }

    [Column("tue")]
    public bool? Tue { get; set; }

    [Column("wed")]
    public bool? Wed { get; set; }

    [Column("thu")]
    public bool? Thu { get; set; }

    [Column("fri")]
    public bool? Fri { get; set; }

    [Column("sat")]
    public bool? Sat { get; set; }

    [Column("sun")]
    public bool? Sun { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("ProjectTaskRecurrenceCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("ProjectTaskRecurrenceWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("Recurrence")]
    [NotMapped]
    public virtual ICollection<ProjectTask> ProjectTasks { get; } = new List<ProjectTask>();

}
