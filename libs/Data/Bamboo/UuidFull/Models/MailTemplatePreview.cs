using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MailTemplatePreview
{
    public Guid Id { get; set; }

    public Guid? MailTemplateId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? ResourceRef { get; set; }

    public string? Lang { get; set; }

    public string? ErrorMsg { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailTemplate? MailTemplate { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
