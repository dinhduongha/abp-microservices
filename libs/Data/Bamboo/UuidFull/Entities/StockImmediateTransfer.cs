using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_immediate_transfer")]
public partial class StockImmediateTransfer
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("show_transfers")]
    public bool? ShowTransfers { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockImmediateTransferCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("ImmediateTransfer")]
    public virtual ICollection<StockImmediateTransferLine> StockImmediateTransferLines { get; } = new List<StockImmediateTransferLine>();

    [ForeignKey("WriteUid")]
    [InverseProperty("StockImmediateTransferWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("StockImmediateTransferId")]
    [InverseProperty("StockImmediateTransfers")]
    public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();
}
