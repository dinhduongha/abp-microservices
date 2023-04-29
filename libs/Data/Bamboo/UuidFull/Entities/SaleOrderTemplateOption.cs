using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("sale_order_template_option")]
[Index("CompanyId", Name = "sale_order_template_option_company_id_index")]
[Index("SaleOrderTemplateId", Name = "sale_order_template_option_sale_order_template_id_index")]
public partial class SaleOrderTemplateOption
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sale_order_template_id")]
    public Guid? SaleOrderTemplateId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("uom_id")]
    public Guid? UomId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("quantity")]
    public decimal? Quantity { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("SaleOrderTemplateOptions")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("SaleOrderTemplateOptionCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("SaleOrderTemplateOptions")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("SaleOrderTemplateId")]
    [InverseProperty("SaleOrderTemplateOptions")]
    public virtual SaleOrderTemplate? SaleOrderTemplate { get; set; }

    [ForeignKey("UomId")]
    [InverseProperty("SaleOrderTemplateOptions")]
    public virtual UomUom? Uom { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("SaleOrderTemplateOptionWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
