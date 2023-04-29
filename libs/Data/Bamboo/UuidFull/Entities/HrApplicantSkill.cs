using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_applicant_skill")]
[Index("ApplicantId", "SkillId", Name = "hr_applicant_skill__unique_skill", IsUnique = true)]
public partial class HrApplicantSkill
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("applicant_id")]
    public Guid? ApplicantId { get; set; }

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

    [ForeignKey("ApplicantId")]
    [InverseProperty("HrApplicantSkills")]
    public virtual HrApplicant? Applicant { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrApplicantSkillCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("SkillId")]
    [InverseProperty("HrApplicantSkills")]
    public virtual HrSkill? Skill { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrApplicantSkillWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
