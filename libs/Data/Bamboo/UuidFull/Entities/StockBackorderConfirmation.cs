using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_backorder_confirmation")]
public partial class StockBackorderConfirmation
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
    [InverseProperty("StockBackorderConfirmationCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("BackorderConfirmation")]
    public virtual ICollection<StockBackorderConfirmationLine> StockBackorderConfirmationLines { get; } = new List<StockBackorderConfirmationLine>();

    [ForeignKey("WriteUid")]
    [InverseProperty("StockBackorderConfirmationWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("StockBackorderConfirmationId")]
    [InverseProperty("StockBackorderConfirmations")]
    public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();
}
