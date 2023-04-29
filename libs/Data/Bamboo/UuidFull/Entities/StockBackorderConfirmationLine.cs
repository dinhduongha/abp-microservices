using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_backorder_confirmation_line")]
public partial class StockBackorderConfirmationLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("backorder_confirmation_id")]
    public Guid? BackorderConfirmationId { get; set; }

    [Column("picking_id")]
    public Guid? PickingId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("to_backorder")]
    public bool? ToBackorder { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("BackorderConfirmationId")]
    [InverseProperty("StockBackorderConfirmationLines")]
    public virtual StockBackorderConfirmation? BackorderConfirmation { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockBackorderConfirmationLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PickingId")]
    [InverseProperty("StockBackorderConfirmationLines")]
    public virtual StockPicking? Picking { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("StockBackorderConfirmationLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
