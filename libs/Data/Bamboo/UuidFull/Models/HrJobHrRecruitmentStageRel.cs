using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrJobHrRecruitmentStageRel
{
    public long HrRecruitmentStageId { get; set; }

    public Guid HrJobId { get; set; }

    public virtual HrJob HrJob { get; set; } = null!;
}
