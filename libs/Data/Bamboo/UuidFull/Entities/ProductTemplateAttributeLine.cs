using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("product_template_attribute_line")]
[Index("AttributeId", Name = "product_template_attribute_line_attribute_id_index")]
[Index("ProductTmplId", Name = "product_template_attribute_line_product_tmpl_id_index")]
public partial class ProductTemplateAttributeLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("product_tmpl_id")]
    public Guid? ProductTmplId { get; set; }

    [Column("attribute_id")]
    public long? AttributeId { get; set; }

    [Column("value_count")]
    public long? ValueCount { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProductTemplateAttributeLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("AttributeLine")]
    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; } = new List<ProductTemplateAttributeValue>();

    [ForeignKey("ProductTmplId")]
    [InverseProperty("ProductTemplateAttributeLines")]
    public virtual ProductTemplate? ProductTmpl { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ProductTemplateAttributeLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ProductTemplateAttributeLineId")]
    [InverseProperty("ProductTemplateAttributeLines")]
    public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; } = new List<ProductAttributeValue>();
}
