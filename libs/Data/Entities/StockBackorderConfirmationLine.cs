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
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("to_backorder")]
    public bool? ToBackorder { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("BackorderConfirmationId")]
    [InverseProperty("StockBackorderConfirmationLines")]
    public virtual StockBackorderConfirmation? BackorderConfirmation { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("StockBackorderConfirmationLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PickingId")]
    [InverseProperty("StockBackorderConfirmationLines")]
    public virtual StockPicking? Picking { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("StockBackorderConfirmationLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
