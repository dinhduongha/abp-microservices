using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ApplicantGetRefuseReason
{
    public Guid Id { get; set; }

    public Guid? RefuseReasonId { get; set; }

    public Guid? TemplateId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? SendMail { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrApplicantRefuseReason? RefuseReason { get; set; }

    public virtual MailTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();
}
