using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrEmployeeSkillLog
{
    public Guid Id { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? DepartmentId { get; set; }

    public Guid? SkillId { get; set; }

    public long? SkillLevelId { get; set; }

    public long? SkillTypeId { get; set; }

    public long? LevelProgress { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateOnly? Date { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual HrSkill? Skill { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
