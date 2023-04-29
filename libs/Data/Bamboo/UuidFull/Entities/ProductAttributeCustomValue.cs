using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("product_attribute_custom_value")]
[Index("CustomProductTemplateAttributeValueId", "SaleOrderLineId", Name = "product_attribute_custom_value_sol_custom_value_unique", IsUnique = true)]
public partial class ProductAttributeCustomValue
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("custom_product_template_attribute_value_id")]
    public Guid? CustomProductTemplateAttributeValueId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("custom_value")]
    public string? CustomValue { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("sale_order_line_id")]
    public Guid? SaleOrderLineId { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProductAttributeCustomValueCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CustomProductTemplateAttributeValueId")]
    [InverseProperty("ProductAttributeCustomValues")]
    public virtual ProductTemplateAttributeValue? CustomProductTemplateAttributeValue { get; set; }

    [ForeignKey("SaleOrderLineId")]
    [InverseProperty("ProductAttributeCustomValues")]
    public virtual SaleOrderLine? SaleOrderLine { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ProductAttributeCustomValueWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
