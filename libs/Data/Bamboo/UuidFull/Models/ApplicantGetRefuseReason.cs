using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ApplicantGetRefuseReason
{
    public Guid Id { get; set; }

    public Guid? RefuseReasonId { get; set; }

    public Guid? TemplateId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public bool? SendMail { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrApplicantRefuseReason? RefuseReason { get; set; }

    public virtual MailTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();
}
