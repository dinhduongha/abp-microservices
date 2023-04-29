using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProjectTaskType
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? MailTemplateId { get; set; }

    public Guid? RatingTemplateId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? LegendBlocked { get; set; }

    public string? LegendDone { get; set; }

    public string? LegendNormal { get; set; }

    public bool? Active { get; set; }

    public bool? Fold { get; set; }

    public bool? AutoValidationKanbanState { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? SmsTemplateId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailTemplate? MailTemplate { get; set; }

    public virtual MailTemplate? RatingTemplate { get; set; }

    public virtual SmsTemplate? SmsTemplate { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
