using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrSkillType
{
    public long Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<HrApplicantSkill> HrApplicantSkills { get; } = new List<HrApplicantSkill>();

    //public virtual ICollection<HrEmployeeSkillLog> HrEmployeeSkillLogs { get; } = new List<HrEmployeeSkillLog>();

    //public virtual ICollection<HrEmployeeSkill> HrEmployeeSkills { get; } = new List<HrEmployeeSkill>();

    //public virtual ICollection<HrSkillLevel> HrSkillLevels { get; } = new List<HrSkillLevel>();

    //public virtual ICollection<HrSkill> HrSkills { get; } = new List<HrSkill>();

    public virtual ResUser? WriteU { get; set; }
}
