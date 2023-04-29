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

[Table("product_tag")]
[Index("Name", Name = "product_tag_name_uniq", IsUnique = true)]
[Index("WebsiteId", Name = "product_tag_website_id_index")]
public partial class ProductTag
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("website_id")]
    public Guid? WebsiteId { get; set; }

    [Column("ribbon_id")]
    public Guid? RibbonId { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("ProductTagCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("RibbonId")]
    //[InverseProperty("ProductTags")]
    public virtual ProductRibbon? Ribbon { get; set; }

    [ForeignKey("WebsiteId")]
    //[InverseProperty("ProductTags")]
    public virtual Website? Website { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("ProductTagWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ProductTagId")]
    [InverseProperty("ProductTags")]
    [NotMapped]
    public virtual ICollection<ProductProduct> ProductProducts { get; } = new List<ProductProduct>();

    [ForeignKey("ProductTagId")]
    [InverseProperty("ProductTags")]
    [NotMapped]
    public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();
}
