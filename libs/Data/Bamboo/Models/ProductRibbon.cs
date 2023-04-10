using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProductRibbon
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? BgColor { get; set; }

    public string? TextColor { get; set; }

    public string? HtmlClass { get; set; }

    public string? Html { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<ProductTag> ProductTags { get; } = new List<ProductTag>();

    //public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();

    public virtual ResUser? WriteU { get; set; }
}
