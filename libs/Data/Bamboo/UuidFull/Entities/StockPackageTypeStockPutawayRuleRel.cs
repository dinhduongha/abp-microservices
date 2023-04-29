using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("StockPutawayRuleId", "StockPackageTypeId")]
[Table("stock_package_type_stock_putaway_rule_rel")]
[Index("StockPackageTypeId", "StockPutawayRuleId", Name = "stock_package_type_stock_puta_stock_package_type_id_stock_p_idx")]
public partial class StockPackageTypeStockPutawayRuleRel
{
    [Key]
    [Column("stock_putaway_rule_id")]
    public Guid StockPutawayRuleId { get; set; }

    [Key]
    [Column("stock_package_type_id")]
    public long StockPackageTypeId { get; set; }

    [ForeignKey("StockPutawayRuleId")]
    [InverseProperty("StockPackageTypeStockPutawayRuleRels")]
    public virtual StockPutawayRule StockPutawayRule { get; set; } = null!;
}
