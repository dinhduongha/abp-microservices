using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("product_public_category")]
[Index("ParentId", Name = "product_public_category_parent_id_index")]
[Index("ParentPath", Name = "product_public_category_parent_path_index")]
[Index("Sequence", Name = "product_public_category_sequence_index")]
[Index("WebsiteId", Name = "product_public_category_website_id_index")]
public partial class ProductPublicCategory
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("website_id")]
    public Guid? WebsiteId { get; set; }

    [Column("parent_id")]
    public long? ParentId { get; set; }

    [Column("sequence", TypeName = "bigserial")]
    public long Sequence { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("website_meta_og_img")]
    public string? WebsiteMetaOgImg { get; set; }

    [Column("parent_path")]
    public string? ParentPath { get; set; }

    [Column("website_meta_title", TypeName = "jsonb")]
    public string? WebsiteMetaTitle { get; set; }

    [Column("website_meta_description", TypeName = "jsonb")]
    public string? WebsiteMetaDescription { get; set; }

    [Column("website_meta_keywords", TypeName = "jsonb")]
    public string? WebsiteMetaKeywords { get; set; }

    [Column("seo_name", TypeName = "jsonb")]
    public string? SeoName { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("website_description", TypeName = "jsonb")]
    public string? WebsiteDescription { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("ProductPublicCategoryCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ParentId")]
    //[InverseProperty("InverseParent")]
    public virtual ProductPublicCategory? Parent { get; set; }

    [ForeignKey("WebsiteId")]
    //[InverseProperty("ProductPublicCategories")]
    public virtual Website? Website { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("ProductPublicCategoryWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("Parent")]
    [NotMapped]
    public virtual ICollection<ProductPublicCategory> InverseParent { get; } = new List<ProductPublicCategory>();

    [ForeignKey("ProductPublicCategoryId")]
    [InverseProperty("ProductPublicCategories")]
    [NotMapped]
    public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();
}
