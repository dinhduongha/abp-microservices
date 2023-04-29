using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MailLinkPreview
{
    public Guid Id { get; set; }

    public Guid? MessageId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? SourceUrl { get; set; }

    public string? OgType { get; set; }

    public string? OgTitle { get; set; }

    public string? OgImage { get; set; }

    public string? OgMimetype { get; set; }

    public string? ImageMimetype { get; set; }

    public string? OgDescription { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailMessage? Message { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
