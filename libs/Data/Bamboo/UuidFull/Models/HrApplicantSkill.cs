using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrApplicantSkill
{
    public Guid Id { get; set; }

    public Guid? ApplicantId { get; set; }

    public Guid? SkillId { get; set; }

    public long? SkillLevelId { get; set; }

    public long? SkillTypeId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual HrApplicant? Applicant { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrSkill? Skill { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
