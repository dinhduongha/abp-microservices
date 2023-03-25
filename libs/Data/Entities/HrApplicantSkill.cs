using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

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
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("ApplicantId")]
    [InverseProperty("HrApplicantSkills")]
    public virtual HrApplicant? Applicant { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("HrApplicantSkillCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("SkillId")]
    //[InverseProperty("HrApplicantSkills")]
    public virtual HrSkill? Skill { get; set; }

    [ForeignKey("SkillLevelId")]
    //[InverseProperty("HrApplicantSkills")]
    public virtual HrSkillLevel? SkillLevel { get; set; }

    [ForeignKey("SkillTypeId")]
    //[InverseProperty("HrApplicantSkills")]
    public virtual HrSkillType? SkillType { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("HrApplicantSkillWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
