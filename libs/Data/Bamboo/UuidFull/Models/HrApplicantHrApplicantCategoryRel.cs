using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrApplicantHrApplicantCategoryRel
{
    public Guid HrApplicantId { get; set; }

    public long HrApplicantCategoryId { get; set; }

    public virtual HrApplicant HrApplicant { get; set; } = null!;
}
