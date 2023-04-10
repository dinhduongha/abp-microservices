using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProjectTag
{
    public long Id { get; set; }

    public long? Color { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ProjectProject> ProjectProjects { get; } = new List<ProjectProject>();

    //public virtual ICollection<ProjectTask> ProjectTasks { get; } = new List<ProjectTask>();
}
