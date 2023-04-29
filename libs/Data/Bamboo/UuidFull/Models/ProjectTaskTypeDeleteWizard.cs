using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProjectTaskTypeDeleteWizard
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ProjectTaskTypeProjectTaskTypeDeleteWizardRel> ProjectTaskTypeProjectTaskTypeDeleteWizardRels { get; } = new List<ProjectTaskTypeProjectTaskTypeDeleteWizardRel>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProjectProject> ProjectProjects { get; } = new List<ProjectProject>();
}
