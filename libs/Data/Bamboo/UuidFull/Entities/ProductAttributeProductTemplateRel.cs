using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("ProductAttributeId", "ProductTemplateId")]
[Table("product_attribute_product_template_rel")]
[Index("ProductTemplateId", "ProductAttributeId", Name = "product_attribute_product_tem_product_template_id_product_a_idx")]
public partial class ProductAttributeProductTemplateRel
{
    [Key]
    [Column("product_attribute_id")]
    public long ProductAttributeId { get; set; }

    [Key]
    [Column("product_template_id")]
    public Guid ProductTemplateId { get; set; }

    [ForeignKey("ProductTemplateId")]
    [InverseProperty("ProductAttributeProductTemplateRels")]
    public virtual ProductTemplate ProductTemplate { get; set; } = null!;
}
