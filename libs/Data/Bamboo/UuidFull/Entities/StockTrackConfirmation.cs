using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_track_confirmation")]
public partial class StockTrackConfirmation
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockTrackConfirmationCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Wizard")]
    public virtual ICollection<StockTrackLine> StockTrackLines { get; } = new List<StockTrackLine>();

    [ForeignKey("WriteUid")]
    [InverseProperty("StockTrackConfirmationWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("StockTrackConfirmationId")]
    [InverseProperty("StockTrackConfirmations")]
    public virtual ICollection<ProductProduct> ProductProducts { get; } = new List<ProductProduct>();

    [ForeignKey("StockTrackConfirmationId")]
    [InverseProperty("StockTrackConfirmations")]
    public virtual ICollection<StockQuant> StockQuants { get; } = new List<StockQuant>();
}
