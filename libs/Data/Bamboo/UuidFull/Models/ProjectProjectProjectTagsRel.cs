using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProjectProjectProjectTagsRel
{
    public Guid ProjectProjectId { get; set; }

    public long ProjectTagsId { get; set; }

    public virtual ProjectProject ProjectProject { get; set; } = null!;
}
