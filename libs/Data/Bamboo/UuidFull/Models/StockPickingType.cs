using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class StockPickingType
{
    public Guid Id { get; set; }

    public long? Color { get; set; }

    public long Sequence { get; set; }

    public Guid? SequenceId { get; set; }

    public Guid? DefaultLocationSrcId { get; set; }

    public Guid? DefaultLocationDestId { get; set; }

    public Guid? ReturnPickingTypeId { get; set; }

    public Guid? WarehouseId { get; set; }

    public long? ReservationDaysBefore { get; set; }

    public long? ReservationDaysBeforePriority { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? SequenceCode { get; set; }

    public string? Code { get; set; }

    public string? ReservationMethod { get; set; }

    public string? Barcode { get; set; }

    public string? CreateBackorder { get; set; }

    public string? Name { get; set; }

    public bool? ShowEntirePacks { get; set; }

    public bool? Active { get; set; }

    public bool? UseCreateLots { get; set; }

    public bool? UseExistingLots { get; set; }

    public bool? PrintLabel { get; set; }

    public bool? ShowOperations { get; set; }

    public bool? ShowReserved { get; set; }

    public bool? AutoShowReceptionReport { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public bool? IsRepairable { get; set; }

    public bool? UseCreateComponentsLots { get; set; }

    public bool? UseAutoConsumeComponentsLots { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? DefaultLocationDest { get; set; }

    public virtual StockLocation? DefaultLocationSrc { get; set; }

    public virtual ICollection<StockPickingType> InverseReturnPickingType { get; } = new List<StockPickingType>();

    public virtual ICollection<MrpBom> MrpBoms { get; } = new List<MrpBom>();

    public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();

    public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

    public virtual StockPickingType? ReturnPickingType { get; set; }

    public virtual IrSequence? SequenceNavigation { get; set; }

    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();

    public virtual ICollection<StockRule> StockRules { get; } = new List<StockRule>();

    public virtual ICollection<StockWarehouse> StockWarehouseInTypes { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseIntTypes { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseManuTypes { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseOutTypes { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehousePackTypes { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehousePbmTypes { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehousePickTypes { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehousePosTypes { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseReturnTypes { get; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseSamTypes { get; } = new List<StockWarehouse>();

    public virtual StockWarehouse? Warehouse { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
