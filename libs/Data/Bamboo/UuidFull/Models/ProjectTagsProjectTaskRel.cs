using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProjectTagsProjectTaskRel
{
    public Guid ProjectTaskId { get; set; }

    public long ProjectTagsId { get; set; }

    public virtual ProjectTask ProjectTask { get; set; } = null!;
}
