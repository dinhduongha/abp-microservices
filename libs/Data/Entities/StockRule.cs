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

[Table("stock_rule")]
public partial class StockRule: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("group_id")]
    public Guid? GroupId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("location_dest_id")]
    public Guid? LocationDestId { get; set; }

    [Column("location_src_id")]
    public Guid? LocationSrcId { get; set; }

    [Column("route_id")]
    public Guid? RouteId { get; set; }

    [Column("route_sequence")]
    public long? RouteSequence { get; set; }

    [Column("picking_type_id")]
    public Guid? PickingTypeId { get; set; }

    [Column("delay")]
    public long? Delay { get; set; }

    [Column("partner_address_id")]
    public Guid? PartnerAddressId { get; set; }

    [Column("warehouse_id")]
    public Guid? WarehouseId { get; set; }

    [Column("propagate_warehouse_id")]
    public Guid? PropagateWarehouseId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("group_propagation_option")]
    public string? GroupPropagationOption { get; set; }

    [Column("action")]
    public string? Action { get; set; }

    [Column("procure_method")]
    public string? ProcureMethod { get; set; }

    [Column("auto")]
    public string? Auto { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("propagate_cancel")]
    public bool? PropagateCancel { get; set; }

    [Column("propagate_carrier")]
    public bool? PropagateCarrier { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("TenantId")]
    [InverseProperty("StockRules")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("StockRuleCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("GroupId")]
    [InverseProperty("StockRules")]
    public virtual ProcurementGroup? Group { get; set; }

    [ForeignKey("LocationDestId")]
    [InverseProperty("StockRuleLocationDests")]
    public virtual StockLocation? LocationDest { get; set; }

    [ForeignKey("LocationSrcId")]
    [InverseProperty("StockRuleLocationSrcs")]
    public virtual StockLocation? LocationSrc { get; set; }

    [ForeignKey("PartnerAddressId")]
    [InverseProperty("StockRules")]
    public virtual ResPartner? PartnerAddress { get; set; }

    [ForeignKey("PickingTypeId")]
    [InverseProperty("StockRules")]
    public virtual StockPickingType? PickingType { get; set; }

    [ForeignKey("PropagateWarehouseId")]
    [InverseProperty("StockRulePropagateWarehouses")]
    public virtual StockWarehouse? PropagateWarehouse { get; set; }

    [ForeignKey("RouteId")]
    [InverseProperty("StockRules")]
    public virtual StockRoute? Route { get; set; }

    [InverseProperty("Rule")]
    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    [InverseProperty("BuyPull")]
    public virtual ICollection<StockWarehouse> StockWarehouseBuyPulls { get; } = new List<StockWarehouse>();

    [InverseProperty("ManufactureMtoPull")]
    public virtual ICollection<StockWarehouse> StockWarehouseManufactureMtoPulls { get; } = new List<StockWarehouse>();

    [InverseProperty("ManufacturePull")]
    public virtual ICollection<StockWarehouse> StockWarehouseManufacturePulls { get; } = new List<StockWarehouse>();

    [InverseProperty("MtoPull")]
    public virtual ICollection<StockWarehouse> StockWarehouseMtoPulls { get; } = new List<StockWarehouse>();

    [InverseProperty("PbmMtoPull")]
    public virtual ICollection<StockWarehouse> StockWarehousePbmMtoPulls { get; } = new List<StockWarehouse>();

    [InverseProperty("SamRule")]
    public virtual ICollection<StockWarehouse> StockWarehouseSamRules { get; } = new List<StockWarehouse>();

    [ForeignKey("WarehouseId")]
    [InverseProperty("StockRuleWarehouses")]
    public virtual StockWarehouse? Warehouse { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("StockRuleWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
