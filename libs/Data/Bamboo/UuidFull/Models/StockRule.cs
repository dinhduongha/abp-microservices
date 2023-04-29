using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockRule
{
    public Guid Id { get; set; }

    public Guid? GroupId { get; set; }

    public long Sequence { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? LocationDestId { get; set; }

    public Guid? LocationSrcId { get; set; }

    public Guid? RouteId { get; set; }

    public long? RouteSequence { get; set; }

    public Guid? PickingTypeId { get; set; }

    public long? Delay { get; set; }

    public Guid? PartnerAddressId { get; set; }

    public Guid? WarehouseId { get; set; }

    public Guid? PropagateWarehouseId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? GroupPropagationOption { get; set; }

    public string? Action { get; set; }

    public string? ProcureMethod { get; set; }

    public string? Auto { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public bool? PropagateCancel { get; set; }

    public bool? PropagateCarrier { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProcurementGroup? Group { get; set; }

    public virtual StockLocation? LocationDest { get; set; }

    public virtual StockLocation? LocationSrc { get; set; }

    public virtual ResPartner? PartnerAddress { get; set; }

    public virtual StockPickingType? PickingType { get; set; }

    public virtual StockWarehouse? PropagateWarehouse { get; set; }

    public virtual StockRoute? Route { get; set; }

    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    public virtual ICollection<StockWarehouse> StockWarehouseBuyPulls { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseManufactureMtoPulls { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseManufacturePulls { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseMtoPulls { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehousePbmMtoPulls { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseSamRules { get; } = new List<StockWarehouse>();

    public virtual StockWarehouse? Warehouse { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
