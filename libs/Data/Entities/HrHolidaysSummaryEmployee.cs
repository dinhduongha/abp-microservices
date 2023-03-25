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

[Table("hr_holidays_summary_employee")]
public partial class HrHolidaysSummaryEmployee
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("holiday_type")]
    public string? HolidayType { get; set; }

    [Column("date_from")]
    public DateOnly? DateFrom { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("HrHolidaysSummaryEmployeeCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("HrHolidaysSummaryEmployeeWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("SumId")]
    [InverseProperty("Sums")]
    [NotMapped]
    public virtual ICollection<HrEmployee> Emps { get; } = new List<HrEmployee>();
}
