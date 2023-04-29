using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProjectTaskTypeRel
{
    public long TypeId { get; set; }

    public Guid ProjectId { get; set; }

    public virtual ProjectProject Project { get; set; } = null!;
}
