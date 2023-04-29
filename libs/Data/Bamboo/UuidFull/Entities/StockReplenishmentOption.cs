using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_replenishment_option")]
public partial class StockReplenishmentOption
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("route_id")]
    public Guid? RouteId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("replenishment_info_id")]
    public Guid? ReplenishmentInfoId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockReplenishmentOptionCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("StockReplenishmentOptions")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("ReplenishmentInfoId")]
    [InverseProperty("StockReplenishmentOptions")]
    public virtual StockReplenishmentInfo? ReplenishmentInfo { get; set; }

    [ForeignKey("RouteId")]
    [InverseProperty("StockReplenishmentOptions")]
    public virtual StockRoute? Route { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("StockReplenishmentOptionWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
