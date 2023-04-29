using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProjectTaskTypeProjectTaskTypeDeleteWizardRel
{
    public Guid ProjectTaskTypeDeleteWizardId { get; set; }

    public long ProjectTaskTypeId { get; set; }

    public virtual ProjectTaskTypeDeleteWizard ProjectTaskTypeDeleteWizard { get; set; } = null!;
}
