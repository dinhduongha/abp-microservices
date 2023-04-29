using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("pos_pack_operation_lot")]
public partial class PosPackOperationLot
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("pos_order_line_id")]
    public Guid? PosOrderLineId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("lot_name")]
    public string? LotName { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("PosPackOperationLotCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PosOrderLineId")]
    [InverseProperty("PosPackOperationLots")]
    public virtual PosOrderLine? PosOrderLine { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("PosPackOperationLotWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
