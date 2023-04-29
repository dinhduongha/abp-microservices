using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrSkill
{
    public Guid Id { get; set; }

    public Guid? Sequence { get; set; }

    public long? SkillTypeId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrApplicantSkill> HrApplicantSkills { get; } = new List<HrApplicantSkill>();

    public virtual ICollection<HrEmployeeSkillLog> HrEmployeeSkillLogs { get; } = new List<HrEmployeeSkillLog>();

    public virtual ICollection<HrEmployeeSkill> HrEmployeeSkills { get; } = new List<HrEmployeeSkill>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();
}
