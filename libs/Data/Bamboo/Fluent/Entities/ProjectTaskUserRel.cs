using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProjectTaskUserRel
{
    public Guid Id { get; set; }

    public Guid? TaskId { get; set; }

    public Guid? UserId { get; set; }

    public long? StageId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProjectTaskType? Stage { get; set; }

    public virtual ProjectTask? Task { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
