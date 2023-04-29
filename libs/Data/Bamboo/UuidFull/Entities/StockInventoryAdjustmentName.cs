using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_inventory_adjustment_name")]
public partial class StockInventoryAdjustmentName
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("inventory_adjustment_name")]
    public string? InventoryAdjustmentName { get; set; }

    [Column("show_info")]
    public bool? ShowInfo { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockInventoryAdjustmentNameCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("StockInventoryAdjustmentNameWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("StockInventoryAdjustmentNameId")]
    [InverseProperty("StockInventoryAdjustmentNames")]
    public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();
}
