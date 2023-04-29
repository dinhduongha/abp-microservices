using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProjectUpdate
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public long? Progress { get; set; }

    public Guid? UserId { get; set; }

    public Guid? ProjectId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? EmailCc { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public DateOnly? Date { get; set; }

    public string? Description { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ProjectProject? Project { get; set; }

    public virtual ICollection<ProjectProject> ProjectProjects { get; } = new List<ProjectProject>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
