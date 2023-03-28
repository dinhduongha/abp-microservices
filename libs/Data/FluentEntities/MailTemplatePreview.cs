using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailTemplatePreview
{
    public Guid Id { get; set; }

    public Guid? MailTemplateId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? ResourceRef { get; set; }

    public string? Lang { get; set; }

    public string? ErrorMsg { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailTemplate? MailTemplate { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
