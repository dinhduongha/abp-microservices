﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_employee_skill_log")]
[Index("EmployeeId", "DepartmentId", "SkillId", "Date", Name = "hr_employee_skill_log__unique_skill_log", IsUnique = true)]
public partial class HrEmployeeSkillLog
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("employee_id")]
    public Guid? EmployeeId { get; set; }

    [Column("department_id")]
    public Guid? DepartmentId { get; set; }

    [Column("skill_id")]
    public Guid? SkillId { get; set; }

    [Column("skill_level_id")]
    public long? SkillLevelId { get; set; }

    [Column("skill_type_id")]
    public long? SkillTypeId { get; set; }

    [Column("level_progress")]
    public long? LevelProgress { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrEmployeeSkillLogCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("HrEmployeeSkillLogs")]
    public virtual HrDepartment? Department { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("HrEmployeeSkillLogs")]
    public virtual HrEmployee? Employee { get; set; }

    [ForeignKey("SkillId")]
    [InverseProperty("HrEmployeeSkillLogs")]
    public virtual HrSkill? Skill { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrEmployeeSkillLogWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
