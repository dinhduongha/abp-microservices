using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProjectMilestone
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? ProjectId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public DateOnly? Deadline { get; set; }

    public DateOnly? ReachedDate { get; set; }

    public bool? IsReached { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? SaleLineId { get; set; }

    public double? QuantityPercentage { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ProjectProject? Project { get; set; }

    //public virtual ICollection<ProjectTask> ProjectTasks { get; } = new List<ProjectTask>();

    public virtual SaleOrderLine? SaleLine { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
