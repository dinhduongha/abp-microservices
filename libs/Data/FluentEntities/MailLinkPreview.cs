using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailLinkPreview
{
    public Guid Id { get; set; }

    public Guid? MessageId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? SourceUrl { get; set; }

    public string? OgType { get; set; }

    public string? OgTitle { get; set; }

    public string? OgImage { get; set; }

    public string? OgMimetype { get; set; }

    public string? ImageMimetype { get; set; }

    public string? OgDescription { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailMessage? Message { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
