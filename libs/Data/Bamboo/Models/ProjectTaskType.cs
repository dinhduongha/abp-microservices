using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProjectTaskType
{
    public long Id { get; set; }

    public long Sequence { get; set; }

    public Guid? MailTemplateId { get; set; }

    public Guid? RatingTemplateId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? LegendBlocked { get; set; }

    public string? LegendDone { get; set; }

    public string? LegendNormal { get; set; }

    public bool? Active { get; set; }

    public bool? Fold { get; set; }

    public bool? AutoValidationKanbanState { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? SmsTemplateId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailTemplate? MailTemplate { get; set; }

    //public virtual ICollection<ProjectTaskUserRel> ProjectTaskUserRels { get; } = new List<ProjectTaskUserRel>();

    //public virtual ICollection<ProjectTask> ProjectTasks { get; } = new List<ProjectTask>();

    public virtual MailTemplate? RatingTemplate { get; set; }

    public virtual SmsTemplate? SmsTemplate { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ProjectTaskTypeDeleteWizard> ProjectTaskTypeDeleteWizards { get; } = new List<ProjectTaskTypeDeleteWizard>();

    //public virtual ICollection<ProjectProject> Projects { get; } = new List<ProjectProject>();
}
