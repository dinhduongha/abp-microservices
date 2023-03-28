using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ProductPublicCategory
{
    public long Id { get; set; }

    public Guid? WebsiteId { get; set; }

    public long? ParentId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? WebsiteMetaOgImg { get; set; }

    public string? ParentPath { get; set; }

    public string? WebsiteMetaTitle { get; set; }

    public string? WebsiteMetaDescription { get; set; }

    public string? WebsiteMetaKeywords { get; set; }

    public string? SeoName { get; set; }

    public string? Name { get; set; }

    public string? WebsiteDescription { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<ProductPublicCategory> InverseParent { get; } = new List<ProductPublicCategory>();

    public virtual ProductPublicCategory? Parent { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();
}
