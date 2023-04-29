using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("product_replenish")]
public partial class ProductReplenish
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("product_tmpl_id")]
    public Guid? ProductTmplId { get; set; }

    [Column("product_uom_id")]
    public Guid? ProductUomId { get; set; }

    [Column("warehouse_id")]
    public Guid? WarehouseId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("product_has_variants")]
    public bool? ProductHasVariants { get; set; }

    [Column("date_planned", TypeName = "timestamp without time zone")]
    public DateTime? DatePlanned { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("quantity")]
    public double? Quantity { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("ProductReplenishes")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProductReplenishCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("ProductReplenishes")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("ProductTmplId")]
    [InverseProperty("ProductReplenishes")]
    public virtual ProductTemplate? ProductTmpl { get; set; }

    [ForeignKey("ProductUomId")]
    [InverseProperty("ProductReplenishes")]
    public virtual UomUom? ProductUom { get; set; }

    [ForeignKey("WarehouseId")]
    [InverseProperty("ProductReplenishes")]
    public virtual StockWarehouse? Warehouse { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ProductReplenishWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ProductReplenishId")]
    [InverseProperty("ProductReplenishes")]
    public virtual ICollection<StockRoute> StockRoutes { get; } = new List<StockRoute>();
}
