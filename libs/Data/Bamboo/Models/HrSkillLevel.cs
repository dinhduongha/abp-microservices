﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrSkillLevel
{
    public long Id { get; set; }

    public long? SkillTypeId { get; set; }

    public Guid? LevelProgress { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public bool? DefaultLevel { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<HrApplicantSkill> HrApplicantSkills { get; } = new List<HrApplicantSkill>();

    //public virtual ICollection<HrEmployeeSkillLog> HrEmployeeSkillLogs { get; } = new List<HrEmployeeSkillLog>();

    //public virtual ICollection<HrEmployeeSkill> HrEmployeeSkills { get; } = new List<HrEmployeeSkill>();

    public virtual HrSkillType? SkillType { get; set; }

    public virtual ResUser? WriteU { get; set; }
}