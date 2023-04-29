using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_employee_skill")]
[Index("EmployeeId", "SkillId", Name = "hr_employee_skill__unique_skill", IsUnique = true)]
public partial class HrEmployeeSkill
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("employee_id")]
    public Guid? EmployeeId { get; set; }

    [Column("skill_id")]
    public Guid? SkillId { get; set; }

    [Column("skill_level_id")]
    public long? SkillLevelId { get; set; }

    [Column("skill_type_id")]
    public long? SkillTypeId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrEmployeeSkillCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("HrEmployeeSkills")]
    public virtual HrEmployee? Employee { get; set; }

    [ForeignKey("SkillId")]
    [InverseProperty("HrEmployeeSkills")]
    public virtual HrSkill? Skill { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrEmployeeSkillWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
