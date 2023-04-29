﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("product_template_attribute_value")]
[Index("AttributeId", Name = "product_template_attribute_value_attribute_id_index")]
[Index("AttributeLineId", Name = "product_template_attribute_value_attribute_line_id_index")]
[Index("AttributeLineId", "ProductAttributeValueId", Name = "product_template_attribute_value_attribute_value_unique", IsUnique = true)]
[Index("ProductAttributeValueId", Name = "product_template_attribute_value_product_attribute_value_id_ind")]
[Index("ProductTmplId", Name = "product_template_attribute_value_product_tmpl_id_index")]
public partial class ProductTemplateAttributeValue
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("product_attribute_value_id")]
    public Guid? ProductAttributeValueId { get; set; }

    [Column("attribute_line_id")]
    public Guid? AttributeLineId { get; set; }

    [Column("product_tmpl_id")]
    public Guid? ProductTmplId { get; set; }

    [Column("attribute_id")]
    public long? AttributeId { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("price_extra")]
    public decimal? PriceExtra { get; set; }

    [Column("ptav_active")]
    public bool? PtavActive { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("AttributeLineId")]
    [InverseProperty("ProductTemplateAttributeValues")]
    public virtual ProductTemplateAttributeLine? AttributeLine { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProductTemplateAttributeValueCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("CustomProductTemplateAttributeValue")]
    public virtual ICollection<ProductAttributeCustomValue> ProductAttributeCustomValues { get; } = new List<ProductAttributeCustomValue>();

    [ForeignKey("ProductAttributeValueId")]
    [InverseProperty("ProductTemplateAttributeValues")]
    public virtual ProductAttributeValue? ProductAttributeValue { get; set; }

    [InverseProperty("ProductTemplateAttributeValue")]
    public virtual ICollection<ProductTemplateAttributeExclusion> ProductTemplateAttributeExclusionsNavigation { get; } = new List<ProductTemplateAttributeExclusion>();

    [ForeignKey("ProductTmplId")]
    [InverseProperty("ProductTemplateAttributeValues")]
    public virtual ProductTemplate? ProductTmpl { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ProductTemplateAttributeValueWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ProductTemplateAttributeValueId")]
    [InverseProperty("ProductTemplateAttributeValues")]
    public virtual ICollection<MrpBomByproduct> MrpBomByproducts { get; } = new List<MrpBomByproduct>();

    [ForeignKey("ProductTemplateAttributeValueId")]
    [InverseProperty("ProductTemplateAttributeValues")]
    public virtual ICollection<MrpBomLine> MrpBomLines { get; } = new List<MrpBomLine>();

    [ForeignKey("ProductTemplateAttributeValueId")]
    [InverseProperty("ProductTemplateAttributeValues")]
    public virtual ICollection<MrpRoutingWorkcenter> MrpRoutingWorkcenters { get; } = new List<MrpRoutingWorkcenter>();

    [ForeignKey("ProductTemplateAttributeValueId")]
    [InverseProperty("ProductTemplateAttributeValues")]
    public virtual ICollection<ProductProduct> ProductProducts { get; } = new List<ProductProduct>();

    [ForeignKey("ProductTemplateAttributeValueId")]
    [InverseProperty("ProductTemplateAttributeValues")]
    public virtual ICollection<ProductTemplateAttributeExclusion> ProductTemplateAttributeExclusions { get; } = new List<ProductTemplateAttributeExclusion>();

    [ForeignKey("ProductTemplateAttributeValueId")]
    [InverseProperty("ProductTemplateAttributeValues")]
    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();
}
