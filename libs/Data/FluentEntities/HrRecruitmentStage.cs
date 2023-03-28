using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrRecruitmentStage
{
    public long Id { get; set; }

    public long Sequence { get; set; }

    public Guid? TemplateId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? LegendBlocked { get; set; }

    public string? LegendDone { get; set; }

    public string? LegendNormal { get; set; }

    public string? Requirements { get; set; }

    public bool? Fold { get; set; }

    public bool? HiredStage { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<HrApplicant> HrApplicantLastStages { get; } = new List<HrApplicant>();

    //public virtual ICollection<HrApplicant> HrApplicantStages { get; } = new List<HrApplicant>();

    public virtual MailTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<HrJob> HrJobs { get; } = new List<HrJob>();
}
