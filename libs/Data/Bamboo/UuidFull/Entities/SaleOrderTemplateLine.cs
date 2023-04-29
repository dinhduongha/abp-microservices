using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("sale_order_template_line")]
[Index("CompanyId", Name = "sale_order_template_line_company_id_index")]
[Index("SaleOrderTemplateId", Name = "sale_order_template_line_sale_order_template_id_index")]
public partial class SaleOrderTemplateLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sale_order_template_id")]
    public Guid? SaleOrderTemplateId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("product_uom_id")]
    public Guid? ProductUomId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("display_type")]
    public string? DisplayType { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("product_uom_qty")]
    public decimal? ProductUomQty { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("SaleOrderTemplateLines")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("SaleOrderTemplateLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("SaleOrderTemplateLines")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("ProductUomId")]
    [InverseProperty("SaleOrderTemplateLines")]
    public virtual UomUom? ProductUom { get; set; }

    [ForeignKey("SaleOrderTemplateId")]
    [InverseProperty("SaleOrderTemplateLines")]
    public virtual SaleOrderTemplate? SaleOrderTemplate { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("SaleOrderTemplateLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
