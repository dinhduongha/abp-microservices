using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class WebsiteTrack
{
    public Guid Id { get; set; }

    public Guid? VisitorId { get; set; }

    public Guid? PageId { get; set; }

    public string? Url { get; set; }

    public DateTime? VisitDatetime { get; set; }

    public Guid? ProductId { get; set; }

    public virtual WebsitePage? Page { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual WebsiteVisitor? Visitor { get; set; }
}
