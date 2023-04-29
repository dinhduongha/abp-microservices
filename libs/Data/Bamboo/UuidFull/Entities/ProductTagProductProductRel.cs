using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("ProductProductId", "ProductTagId")]
[Table("product_tag_product_product_rel")]
[Index("ProductTagId", "ProductProductId", Name = "product_tag_product_product_r_product_tag_id_product_produc_idx")]
public partial class ProductTagProductProductRel
{
    [Key]
    [Column("product_product_id")]
    public Guid ProductProductId { get; set; }

    [Key]
    [Column("product_tag_id")]
    public long ProductTagId { get; set; }

    [ForeignKey("ProductProductId")]
    [InverseProperty("ProductTagProductProductRels")]
    public virtual ProductProduct ProductProduct { get; set; } = null!;
}
