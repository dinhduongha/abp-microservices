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

[Table("hr_holidays_cancel_leave")]
public partial class HrHolidaysCancelLeave
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("leave_id")]
    public Guid? LeaveId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("reason")]
    public string? Reason { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("HrHolidaysCancelLeaveCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LeaveId")]
    //[InverseProperty("HrHolidaysCancelLeaves")]
    public virtual HrLeave? Leave { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("HrHolidaysCancelLeaveWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
