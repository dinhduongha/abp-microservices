using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_holidays_summary_employee")]
public partial class HrHolidaysSummaryEmployee
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("holiday_type")]
    public string? HolidayType { get; set; }

    [Column("date_from")]
    public DateOnly? DateFrom { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrHolidaysSummaryEmployeeCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrHolidaysSummaryEmployeeWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("SumId")]
    [InverseProperty("Sums")]
    public virtual ICollection<HrEmployee> Emps { get; } = new List<HrEmployee>();
}
