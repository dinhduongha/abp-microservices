using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mrp_bom_byproduct")]
[Index("BomId", Name = "mrp_bom_byproduct_bom_id_index")]
[Index("CompanyId", Name = "mrp_bom_byproduct_company_id_index")]
public partial class MrpBomByproduct
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("product_uom_id")]
    public Guid? ProductUomId { get; set; }

    [Column("bom_id")]
    public Guid? BomId { get; set; }

    [Column("operation_id")]
    public Guid? OperationId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("product_qty")]
    public decimal? ProductQty { get; set; }

    [Column("cost_share")]
    public decimal? CostShare { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("BomId")]
    [InverseProperty("MrpBomByproducts")]
    public virtual MrpBom? Bom { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("MrpBomByproducts")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MrpBomByproductCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("OperationId")]
    [InverseProperty("MrpBomByproducts")]
    public virtual MrpRoutingWorkcenter? Operation { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("MrpBomByproducts")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("ProductUomId")]
    [InverseProperty("MrpBomByproducts")]
    public virtual UomUom? ProductUom { get; set; }

    [InverseProperty("Byproduct")]
    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    [ForeignKey("WriteUid")]
    [InverseProperty("MrpBomByproductWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("MrpBomByproductId")]
    [InverseProperty("MrpBomByproducts")]
    public virtual ICollection<ProductTemplateAttributeValue> ProductTemplateAttributeValues { get; } = new List<ProductTemplateAttributeValue>();
}
