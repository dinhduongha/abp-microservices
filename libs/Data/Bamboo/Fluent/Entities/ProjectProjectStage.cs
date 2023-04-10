using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProjectProjectStage
{
    public long Id { get; set; }

    public long Sequence { get; set; }

    public Guid? MailTemplateId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public bool? Fold { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? SmsTemplateId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailTemplate? MailTemplate { get; set; }

    //public virtual ICollection<ProjectProject> ProjectProjects { get; } = new List<ProjectProject>();

    public virtual SmsTemplate? SmsTemplate { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
