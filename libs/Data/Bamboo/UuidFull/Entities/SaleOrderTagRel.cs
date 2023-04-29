using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("OrderId", "TagId")]
[Table("sale_order_tag_rel")]
[Index("TagId", "OrderId", Name = "sale_order_tag_rel_tag_id_order_id_idx")]
public partial class SaleOrderTagRel
{
    [Key]
    [Column("order_id")]
    public Guid OrderId { get; set; }

    [Key]
    [Column("tag_id")]
    public long TagId { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("SaleOrderTagRels")]
    public virtual SaleOrder Order { get; set; } = null!;
}
