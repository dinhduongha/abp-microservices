using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("procurement_group")]
public partial class ProcurementGroup
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("move_type")]
    public string? MoveType { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("pos_order_id")]
    public Guid? PosOrderId { get; set; }

    [Column("sale_id")]
    public Guid? SaleId { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProcurementGroupCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("ProcurementGroup")]
    public virtual ICollection<MrpProduction> MrpProductions { get; } = new List<MrpProduction>();

    [ForeignKey("PartnerId")]
    [InverseProperty("ProcurementGroups")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("PosOrderId")]
    [InverseProperty("ProcurementGroups")]
    public virtual PosOrder? PosOrder { get; set; }

    [InverseProperty("ProcurementGroup")]
    public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    [InverseProperty("Group")]
    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

    [ForeignKey("SaleId")]
    [InverseProperty("ProcurementGroups")]
    public virtual SaleOrder? Sale { get; set; }

    [InverseProperty("ProcurementGroup")]
    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    [InverseProperty("Group")]
    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    [InverseProperty("Group")]
    public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();

    [InverseProperty("Group")]
    public virtual ICollection<StockRule> StockRules { get; } = new List<StockRule>();

    [InverseProperty("Group")]
    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; } = new List<StockWarehouseOrderpoint>();

    [ForeignKey("WriteUid")]
    [InverseProperty("ProcurementGroupWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
