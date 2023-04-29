using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_route")]
[Index("CompanyId", Name = "stock_route_company_id_index")]
public partial class StockRoute
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("supplied_wh_id")]
    public Guid? SuppliedWhId { get; set; }

    [Column("supplier_wh_id")]
    public Guid? SupplierWhId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("product_selectable")]
    public bool? ProductSelectable { get; set; }

    [Column("product_categ_selectable")]
    public bool? ProductCategSelectable { get; set; }

    [Column("warehouse_selectable")]
    public bool? WarehouseSelectable { get; set; }

    [Column("packaging_selectable")]
    public bool? PackagingSelectable { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("sale_selectable")]
    public bool? SaleSelectable { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("StockRoutes")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockRouteCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Route")]
    public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();

    [InverseProperty("Route")]
    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();

    [InverseProperty("Route")]
    public virtual ICollection<StockReplenishmentOption> StockReplenishmentOptions { get; } = new List<StockReplenishmentOption>();

    [InverseProperty("Route")]
    public virtual ICollection<StockRouteCateg> StockRouteCategs { get; } = new List<StockRouteCateg>();

    [InverseProperty("Route")]
    public virtual ICollection<StockRule> StockRules { get; } = new List<StockRule>();

    [InverseProperty("CrossdockRoute")]
    public virtual ICollection<StockWarehouse> StockWarehouseCrossdockRoutes { get; } = new List<StockWarehouse>();

    [InverseProperty("DeliveryRoute")]
    public virtual ICollection<StockWarehouse> StockWarehouseDeliveryRoutes { get; } = new List<StockWarehouse>();

    [InverseProperty("Route")]
    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; } = new List<StockWarehouseOrderpoint>();

    [InverseProperty("PbmRoute")]
    public virtual ICollection<StockWarehouse> StockWarehousePbmRoutes { get; } = new List<StockWarehouse>();

    [InverseProperty("ReceptionRoute")]
    public virtual ICollection<StockWarehouse> StockWarehouseReceptionRoutes { get; } = new List<StockWarehouse>();

    [ForeignKey("SuppliedWhId")]
    [InverseProperty("StockRouteSuppliedWhs")]
    public virtual StockWarehouse? SuppliedWh { get; set; }

    [ForeignKey("SupplierWhId")]
    [InverseProperty("StockRouteSupplierWhs")]
    public virtual StockWarehouse? SupplierWh { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("StockRouteWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("RouteId")]
    [InverseProperty("Routes")]
    public virtual ICollection<StockMove> Moves { get; } = new List<StockMove>();

    [ForeignKey("RouteId")]
    [InverseProperty("Routes")]
    public virtual ICollection<ProductPackaging> Packagings { get; } = new List<ProductPackaging>();

    [ForeignKey("StockRouteId")]
    [InverseProperty("StockRoutes")]
    public virtual ICollection<ProductReplenish> ProductReplenishes { get; } = new List<ProductReplenish>();

    [ForeignKey("RouteId")]
    [InverseProperty("Routes")]
    public virtual ICollection<ProductTemplate> Products { get; } = new List<ProductTemplate>();

    [ForeignKey("StockRouteId")]
    [InverseProperty("StockRoutes")]
    public virtual ICollection<StockRulesReport> StockRulesReports { get; } = new List<StockRulesReport>();

    [ForeignKey("RouteId")]
    [InverseProperty("Routes")]
    public virtual ICollection<StockWarehouse> Warehouses { get; } = new List<StockWarehouse>();
}
