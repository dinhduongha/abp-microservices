using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrApplicantRefuseReason
{
    public Guid Id { get; set; }

    public Guid? TemplateId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ICollection<ApplicantGetRefuseReason> ApplicantGetRefuseReasons { get; } = new List<ApplicantGetRefuseReason>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();

    public virtual MailTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
