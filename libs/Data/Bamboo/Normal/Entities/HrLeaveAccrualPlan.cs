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

[Table("hr_leave_accrual_plan")]
public partial class HrLeaveAccrualPlan
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("time_off_type_id")]
    public long? TimeOffTypeId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("transition_mode")]
    public string? TransitionMode { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("HrLeaveAccrualPlanCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("TimeOffTypeId")]
    //[InverseProperty("HrLeaveAccrualPlans")]
    public virtual HrLeaveType? TimeOffType { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("HrLeaveAccrualPlanWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("AccrualPlan")]
    [NotMapped]
    public virtual ICollection<HrLeaveAccrualLevel> HrLeaveAccrualLevels { get; } = new List<HrLeaveAccrualLevel>();

    [InverseProperty("AccrualPlan")]
    [NotMapped]
    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocations { get; } = new List<HrLeaveAllocation>();

}
