﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrApplicantSkill
{
    public Guid Id { get; set; }

    public Guid? ApplicantId { get; set; }

    public Guid? SkillId { get; set; }

    public long? SkillLevelId { get; set; }

    public long? SkillTypeId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual HrApplicant? Applicant { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrSkill? Skill { get; set; }

    public virtual HrSkillLevel? SkillLevel { get; set; }

    public virtual HrSkillType? SkillType { get; set; }

    public virtual ResUser? WriteU { get; set; }
}