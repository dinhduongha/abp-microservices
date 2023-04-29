using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_holidays_cancel_leave")]
public partial class HrHolidaysCancelLeave
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("leave_id")]
    public Guid? LeaveId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("reason")]
    public string? Reason { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrHolidaysCancelLeaveCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LeaveId")]
    [InverseProperty("HrHolidaysCancelLeaves")]
    public virtual HrLeave? Leave { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrHolidaysCancelLeaveWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
