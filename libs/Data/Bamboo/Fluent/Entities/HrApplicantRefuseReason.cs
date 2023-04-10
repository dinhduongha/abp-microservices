using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrApplicantRefuseReason
{
    public Guid Id { get; set; }

    public Guid? TemplateId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<ApplicantGetRefuseReason> ApplicantGetRefuseReasons { get; } = new List<ApplicantGetRefuseReason>();

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    public virtual MailTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
