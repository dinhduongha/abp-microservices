using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ApplicantSendMail
{
    public Guid Id { get; set; }

    public Guid? TemplateId { get; set; }

    public Guid? AuthorId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Lang { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResPartner? Author { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrApplicant> HrApplicants { get; } = new List<HrApplicant>();
}
