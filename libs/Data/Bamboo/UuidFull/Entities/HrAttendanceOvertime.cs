using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_attendance_overtime")]
[Index("EmployeeId", Name = "hr_attendance_overtime_employee_id_index")]
public partial class HrAttendanceOvertime
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("employee_id")]
    public Guid? EmployeeId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("adjustment")]
    public bool? Adjustment { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("duration")]
    public double? Duration { get; set; }

    [Column("duration_real")]
    public double? DurationReal { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrAttendanceOvertimeCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("HrAttendanceOvertimes")]
    public virtual HrEmployee? Employee { get; set; }

    [InverseProperty("Overtime")]
    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocations { get; } = new List<HrLeaveAllocation>();

    [InverseProperty("Overtime")]
    public virtual ICollection<HrLeave> HrLeaves { get; } = new List<HrLeave>();

    [ForeignKey("WriteUid")]
    [InverseProperty("HrAttendanceOvertimeWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
