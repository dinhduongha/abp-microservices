using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProductRibbon
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? BgColor { get; set; }

    public string? TextColor { get; set; }

    public string? HtmlClass { get; set; }

    public string? Html { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ProductTag> ProductTags { get; } = new List<ProductTag>();

    public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();

    public virtual ResUser? WriteU { get; set; }
}
