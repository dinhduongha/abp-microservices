using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("product_image")]
[Index("ProductTmplId", Name = "product_image_product_tmpl_id_index")]
[Index("ProductVariantId", Name = "product_image_product_variant_id_index")]
public partial class ProductImage
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("product_tmpl_id")]
    public Guid? ProductTmplId { get; set; }

    [Column("product_variant_id")]
    public Guid? ProductVariantId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("video_url")]
    public string? VideoUrl { get; set; }

    [Column("can_image_1024_be_zoomed")]
    public bool? CanImage1024BeZoomed { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProductImageCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ProductTmplId")]
    [InverseProperty("ProductImages")]
    public virtual ProductTemplate? ProductTmpl { get; set; }

    [ForeignKey("ProductVariantId")]
    [InverseProperty("ProductImages")]
    public virtual ProductProduct? ProductVariant { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ProductImageWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
