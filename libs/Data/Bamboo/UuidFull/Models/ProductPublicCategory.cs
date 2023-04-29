using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProductPublicCategory
{
    public Guid Id { get; set; }

    public Guid? WebsiteId { get; set; }

    public long? ParentId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? WebsiteMetaOgImg { get; set; }

    public string? ParentPath { get; set; }

    public string? WebsiteMetaTitle { get; set; }

    public string? WebsiteMetaDescription { get; set; }

    public string? WebsiteMetaKeywords { get; set; }

    public string? SeoName { get; set; }

    public string? Name { get; set; }

    public string? WebsiteDescription { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
