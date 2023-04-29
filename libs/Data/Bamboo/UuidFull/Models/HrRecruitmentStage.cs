using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrRecruitmentStage
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? TemplateId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? LegendBlocked { get; set; }

    public string? LegendDone { get; set; }

    public string? LegendNormal { get; set; }

    public string? Requirements { get; set; }

    public bool? Fold { get; set; }

    public bool? HiredStage { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
