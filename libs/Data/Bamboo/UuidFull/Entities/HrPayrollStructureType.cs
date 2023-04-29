using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_payroll_structure_type")]
public partial class HrPayrollStructureType
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("default_resource_calendar_id")]
    public Guid? DefaultResourceCalendarId { get; set; }

    [Column("country_id")]
    public long? CountryId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrPayrollStructureTypeCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("DefaultResourceCalendarId")]
    [InverseProperty("HrPayrollStructureTypes")]
    public virtual ResourceCalendar? DefaultResourceCalendar { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrPayrollStructureTypeWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
