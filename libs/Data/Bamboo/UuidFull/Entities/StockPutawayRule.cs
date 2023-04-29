using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_putaway_rule")]
[Index("CompanyId", Name = "stock_putaway_rule_company_id_index")]
[Index("LocationInId", Name = "stock_putaway_rule_location_in_id_index")]
public partial class StockPutawayRule
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("category_id")]
    public long? CategoryId { get; set; }

    [Column("location_in_id")]
    public Guid? LocationInId { get; set; }

    [Column("location_out_id")]
    public Guid? LocationOutId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("storage_category_id")]
    public long? StorageCategoryId { get; set; }

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

    [ForeignKey("CompanyId")]
    [InverseProperty("StockPutawayRules")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockPutawayRuleCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LocationInId")]
    [InverseProperty("StockPutawayRuleLocationIns")]
    public virtual StockLocation? LocationIn { get; set; }

    [ForeignKey("LocationOutId")]
    [InverseProperty("StockPutawayRuleLocationOuts")]
    public virtual StockLocation? LocationOut { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("StockPutawayRules")]
    public virtual ProductProduct? Product { get; set; }

    [InverseProperty("StockPutawayRule")]
    public virtual ICollection<StockPackageTypeStockPutawayRuleRel> StockPackageTypeStockPutawayRuleRels { get; } = new List<StockPackageTypeStockPutawayRuleRel>();

    [ForeignKey("WriteUid")]
    [InverseProperty("StockPutawayRuleWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
