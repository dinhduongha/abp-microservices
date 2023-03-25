using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("stock_inventory_adjustment_name")]
public partial class StockInventoryAdjustmentName
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("inventory_adjustment_name")]
    public string? InventoryAdjustmentName { get; set; }

    [Column("show_info")]
    public bool? ShowInfo { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("StockInventoryAdjustmentNameCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("StockInventoryAdjustmentNameWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("StockInventoryAdjustmentNameId")]
    [InverseProperty("StockInventoryAdjustmentNames")]
    public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();
}
