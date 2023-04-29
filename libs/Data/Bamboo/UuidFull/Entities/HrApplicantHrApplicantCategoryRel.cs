using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("HrApplicantId", "HrApplicantCategoryId")]
[Table("hr_applicant_hr_applicant_category_rel")]
[Index("HrApplicantCategoryId", "HrApplicantId", Name = "hr_applicant_hr_applicant_cat_hr_applicant_category_id_hr_a_idx")]
public partial class HrApplicantHrApplicantCategoryRel
{
    [Key]
    [Column("hr_applicant_id")]
    public Guid HrApplicantId { get; set; }

    [Key]
    [Column("hr_applicant_category_id")]
    public long HrApplicantCategoryId { get; set; }

    [ForeignKey("HrApplicantId")]
    [InverseProperty("HrApplicantHrApplicantCategoryRels")]
    public virtual HrApplicant HrApplicant { get; set; } = null!;
}
