using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_leave_accrual_plan")]
public partial class HrLeaveAccrualPlan
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("time_off_type_id")]
    public long? TimeOffTypeId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("transition_mode")]
    public string? TransitionMode { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrLeaveAccrualPlanCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("AccrualPlan")]
    public virtual ICollection<HrLeaveAccrualLevel> HrLeaveAccrualLevels { get; } = new List<HrLeaveAccrualLevel>();

    [InverseProperty("AccrualPlan")]
    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocations { get; } = new List<HrLeaveAllocation>();

    [ForeignKey("WriteUid")]
    [InverseProperty("HrLeaveAccrualPlanWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
