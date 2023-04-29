using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_immediate_transfer_line")]
public partial class StockImmediateTransferLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("immediate_transfer_id")]
    public Guid? ImmediateTransferId { get; set; }

    [Column("picking_id")]
    public Guid? PickingId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("to_immediate")]
    public bool? ToImmediate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockImmediateTransferLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ImmediateTransferId")]
    [InverseProperty("StockImmediateTransferLines")]
    public virtual StockImmediateTransfer? ImmediateTransfer { get; set; }

    [ForeignKey("PickingId")]
    [InverseProperty("StockImmediateTransferLines")]
    public virtual StockPicking? Picking { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("StockImmediateTransferLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
