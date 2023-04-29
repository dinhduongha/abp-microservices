using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mrp_bom_line")]
[Index("BomId", Name = "mrp_bom_line_bom_id_index")]
[Index("CompanyId", Name = "mrp_bom_line_company_id_index")]
[Index("ProductTmplId", Name = "mrp_bom_line_product_tmpl_id_index")]
public partial class MrpBomLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("product_tmpl_id")]
    public Guid? ProductTmplId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("product_uom_id")]
    public Guid? ProductUomId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("bom_id")]
    public Guid? BomId { get; set; }

    [Column("operation_id")]
    public Guid? OperationId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("product_qty")]
    public decimal? ProductQty { get; set; }

    [Column("manual_consumption")]
    public bool? ManualConsumption { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("cost_share")]
    public decimal? CostShare { get; set; }

    [ForeignKey("BomId")]
    [InverseProperty("MrpBomLines")]
    public virtual MrpBom? Bom { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("MrpBomLines")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MrpBomLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("OperationId")]
    [InverseProperty("MrpBomLines")]
    public virtual MrpRoutingWorkcenter? Operation { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("MrpBomLines")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("ProductTmplId")]
    [InverseProperty("MrpBomLines")]
    public virtual ProductTemplate? ProductTmpl { get; set; }

    [ForeignKey("ProductUomId")]
    [InverseProperty("MrpBomLines")]
    public virtual UomUom? ProductUom { get; set; }

    [InverseProperty("BomLine")]
    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    [ForeignKey("WriteUid")]
    [InverseProperty("MrpBomLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("MrpBomLineId")]
    [InverseProperty("MrpBomLines")]
    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; } = new List<ProductTemplateAttributeValue>();
}
