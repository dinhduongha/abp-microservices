using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("RouteId", "CategId")]
[Table("stock_route_categ")]
[Index("CategId", "RouteId", Name = "stock_route_categ_categ_id_route_id_idx")]
public partial class StockRouteCateg
{
    [Key]
    [Column("route_id")]
    public Guid RouteId { get; set; }

    [Key]
    [Column("categ_id")]
    public long CategId { get; set; }

    [ForeignKey("RouteId")]
    [InverseProperty("StockRouteCategs")]
    public virtual StockRoute Route { get; set; } = null!;
}
