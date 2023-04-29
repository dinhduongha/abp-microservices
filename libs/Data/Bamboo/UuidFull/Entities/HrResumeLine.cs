using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_resume_line")]
public partial class HrResumeLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("employee_id")]
    public Guid? EmployeeId { get; set; }

    [Column("line_type_id")]
    public long? LineTypeId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("display_type")]
    public string? DisplayType { get; set; }

    [Column("date_start")]
    public DateOnly? DateStart { get; set; }

    [Column("date_end")]
    public DateOnly? DateEnd { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrResumeLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("HrResumeLines")]
    public virtual HrEmployee? Employee { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrResumeLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
