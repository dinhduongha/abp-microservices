﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("product_template_attribute_exclusion")]
[Index("ProductTemplateAttributeValueId", Name = "product_template_attribute_exclusion_product_template_attribute")]
[Index("ProductTmplId", Name = "product_template_attribute_exclusion_product_tmpl_id_index")]
public partial class ProductTemplateAttributeExclusion
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("product_template_attribute_value_id")]
    public Guid? ProductTemplateAttributeValueId { get; set; }

    [Column("product_tmpl_id")]
    public Guid? ProductTmplId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("ProductTemplateAttributeExclusionCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ProductTemplateAttributeValueId")]
    //[InverseProperty("ProductTemplateAttributeExclusionsNavigation")]
    public virtual ProductTemplateAttributeValue? ProductTemplateAttributeValue { get; set; }

    [ForeignKey("ProductTmplId")]
    //[InverseProperty("ProductTemplateAttributeExclusions")]
    public virtual ProductTemplate? ProductTmpl { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("ProductTemplateAttributeExclusionWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ProductTemplateAttributeExclusionId")]
    [InverseProperty("ProductTemplateAttributeExclusions")]
    [NotMapped]
    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; } = new List<ProductTemplateAttributeValue>();
}
