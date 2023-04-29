using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("HrRecruitmentStageId", "HrJobId")]
[Table("hr_job_hr_recruitment_stage_rel")]
[Index("HrJobId", "HrRecruitmentStageId", Name = "hr_job_hr_recruitment_stage_r_hr_job_id_hr_recruitment_stag_idx")]
public partial class HrJobHrRecruitmentStageRel
{
    [Key]
    [Column("hr_recruitment_stage_id")]
    public long HrRecruitmentStageId { get; set; }

    [Key]
    [Column("hr_job_id")]
    public Guid HrJobId { get; set; }

    [ForeignKey("HrJobId")]
    [InverseProperty("HrJobHrRecruitmentStageRels")]
    public virtual HrJob HrJob { get; set; } = null!;
}
