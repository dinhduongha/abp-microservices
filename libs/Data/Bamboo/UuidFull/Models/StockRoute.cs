using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockRoute
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? SuppliedWhId { get; set; }

    public Guid? SupplierWhId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public bool? ProductSelectable { get; set; }

    public bool? ProductCategSelectable { get; set; }

    public bool? WarehouseSelectable { get; set; }

    public bool? PackagingSelectable { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public bool? SaleSelectable { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();

    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();

    public virtual ICollection<StockReplenishmentOption> StockReplenishmentOptions { get; } = new List<StockReplenishmentOption>();

    public virtual ICollection<StockRouteCateg> StockRouteCategs { get; } = new List<StockRouteCateg>();

    public virtual ICollection<StockRule> StockRules { get; } = new List<StockRule>();

    public virtual ICollection<StockWarehouse> StockWarehouseCrossdockRoutes { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseDeliveryRoutes { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; } = new List<StockWarehouseOrderpoint>();

    public virtual ICollection<StockWarehouse> StockWarehousePbmRoutes { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseReceptionRoutes { get; } = new List<StockWarehouse>();

    public virtual StockWarehouse? SuppliedWh { get; set; }

    public virtual StockWarehouse? SupplierWh { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockMove> Moves { get; } = new List<StockMove>();

    public virtual ICollection<ProductPackaging> Packagings { get; } = new List<ProductPackaging>();

    public virtual ICollection<ProductReplenish> ProductReplenishes { get; } = new List<ProductReplenish>();

    public virtual ICollection<ProductTemplate> Products { get; } = new List<ProductTemplate>();

    public virtual ICollection<StockRulesReport> StockRulesReports { get; } = new List<StockRulesReport>();

    public virtual ICollection<StockWarehouse> Warehouses { get; } = new List<StockWarehouse>();
}
