using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class WebsiteRewrite
{
    public Guid Id { get; set; }

    public Guid? WebsiteId { get; set; }

    public Guid? RouteId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? UrlFrom { get; set; }

    public string? UrlTo { get; set; }

    public string? RedirectType { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual WebsiteRoute? Route { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
