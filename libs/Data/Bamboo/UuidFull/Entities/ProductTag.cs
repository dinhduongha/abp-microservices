using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("product_tag")]
[Index("Name", Name = "product_tag_name_uniq", IsUnique = true)]
[Index("WebsiteId", Name = "product_tag_website_id_index")]
public partial class ProductTag
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("website_id")]
    public Guid? WebsiteId { get; set; }

    [Column("ribbon_id")]
    public Guid? RibbonId { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProductTagCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("RibbonId")]
    [InverseProperty("ProductTags")]
    public virtual ProductRibbon? Ribbon { get; set; }

    [ForeignKey("WebsiteId")]
    [InverseProperty("ProductTags")]
    public virtual Website? Website { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ProductTagWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
