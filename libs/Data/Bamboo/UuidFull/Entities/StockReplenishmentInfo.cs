using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_replenishment_info")]
public partial class StockReplenishmentInfo
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("orderpoint_id")]
    public Guid? OrderpointId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockReplenishmentInfoCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("OrderpointId")]
    [InverseProperty("StockReplenishmentInfos")]
    public virtual StockWarehouseOrderpoint? Orderpoint { get; set; }

    [InverseProperty("ReplenishmentInfo")]
    public virtual ICollection<StockReplenishmentOption> StockReplenishmentOptions { get; } = new List<StockReplenishmentOption>();

    [ForeignKey("WriteUid")]
    [InverseProperty("StockReplenishmentInfoWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("StockReplenishmentInfoId")]
    [InverseProperty("StockReplenishmentInfos")]
    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; } = new List<ProductSupplierinfo>();
}
