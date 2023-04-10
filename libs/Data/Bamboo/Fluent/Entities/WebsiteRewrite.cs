using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class WebsiteRewrite
{
    public Guid Id { get; set; }

    public Guid? WebsiteId { get; set; }

    public Guid? RouteId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? UrlFrom { get; set; }

    public string? UrlTo { get; set; }

    public string? RedirectType { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual WebsiteRoute? Route { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
