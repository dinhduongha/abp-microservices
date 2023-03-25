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

[Table("hr_attendance")]
[Index("EmployeeId", Name = "hr_attendance_employee_id_index")]
public partial class HrAttendance
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("employee_id")]
    public Guid? EmployeeId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("check_in", TypeName = "timestamp without time zone")]
    public DateTime? CheckIn { get; set; }

    [Column("check_out", TypeName = "timestamp without time zone")]
    public DateTime? CheckOut { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("worked_hours")]
    public double? WorkedHours { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("HrAttendanceCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("HrAttendances")]
    public virtual HrEmployee? Employee { get; set; }

    [InverseProperty("LastAttendance")]
    public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("HrAttendanceWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
