using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("ProductTemplateId", "ProductTagId")]
[Table("product_tag_product_template_rel")]
[Index("ProductTagId", "ProductTemplateId", Name = "product_tag_product_template__product_tag_id_product_templa_idx")]
public partial class ProductTagProductTemplateRel
{
    [Key]
    [Column("product_template_id")]
    public Guid ProductTemplateId { get; set; }

    [Key]
    [Column("product_tag_id")]
    public long ProductTagId { get; set; }

    [ForeignKey("ProductTemplateId")]
    [InverseProperty("ProductTagProductTemplateRels")]
    public virtual ProductTemplate ProductTemplate { get; set; } = null!;
}
