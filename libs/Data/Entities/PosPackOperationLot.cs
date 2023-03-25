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

[Table("pos_pack_operation_lot")]
public partial class PosPackOperationLot
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("pos_order_line_id")]
    public Guid? PosOrderLineId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("lot_name")]
    public string? LotName { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("PosPackOperationLotCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PosOrderLineId")]
    [InverseProperty("PosPackOperationLots")]
    public virtual PosOrderLine? PosOrderLine { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("PosPackOperationLotWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
