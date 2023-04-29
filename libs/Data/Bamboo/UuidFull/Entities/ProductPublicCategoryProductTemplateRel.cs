using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("ProductPublicCategoryId", "ProductTemplateId")]
[Table("product_public_category_product_template_rel")]
[Index("ProductTemplateId", "ProductPublicCategoryId", Name = "product_public_category_produ_product_template_id_product_p_idx")]
public partial class ProductPublicCategoryProductTemplateRel
{
    [Key]
    [Column("product_public_category_id")]
    public long ProductPublicCategoryId { get; set; }

    [Key]
    [Column("product_template_id")]
    public Guid ProductTemplateId { get; set; }

    [ForeignKey("ProductTemplateId")]
    [InverseProperty("ProductPublicCategoryProductTemplateRels")]
    public virtual ProductTemplate ProductTemplate { get; set; } = null!;
}
